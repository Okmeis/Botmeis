namespace Botmeis.Communication {

    using System;
    using System.Net.Sockets;
    using System.IO;

    class IrcClient {
        private String username;
        private String channel;
        //Var. Dek.
        private TcpClient tcpClient;
        private StreamReader input;
        private StreamWriter output;
        
        //Constructor
        public IrcClient(string ip, int port, string userName, string password) {
            this.username = userName;
            tcpClient = new TcpClient(ip, port);
            input = new StreamReader(tcpClient.GetStream());
            output = new StreamWriter(tcpClient.GetStream());

            output.WriteLine("PASS " + password);
            output.WriteLine("NICK " + userName);
            output.WriteLine("USER " + userName + " 8 * :" + userName);
            output.Flush();
        }

        public void joinRoom(string channel) {
            this.channel = channel;
            output.WriteLine("JOIN #" + channel);
            output.Flush();
        }

        public void leaveRoom(string channel) {
            this.channel = null;
            output.WriteLine("PART #" + channel);
            output.Flush();

        }

        //I don't remember why I've written it that way, I don't really have any intention of rewriting this function as long as it works since it's just a free time activity and this class isn't the focus of it.
        //I'm just tired, after copying this from my old into my new project, I might head for bed.
        //Yes, yes, those comments are really useful ;)
        public void sendIrcMessage(String message) {
            output.WriteLine(message);
            try {
                output.Flush();
            }
            catch (Exception e) {
                //rewrite this area, else R.I.P. if you have connection issues, it's been years since I touched this class lol
            }
            output.Flush();
        }
        

        public void sendChatMessage(String message) {
            sendIrcMessage(":" + username + "!" + username + "@" + username + ".tmi.twitch.tv PRIVMSG #" + channel + " :" + message);
            output.Flush();
        }
        
        public String readMessage() {
            string message;
            message = input.ReadLine();
            return message;
        }

    }
}