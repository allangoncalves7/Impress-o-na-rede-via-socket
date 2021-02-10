using System;
using System.Net.Sockets;
using System.Collections.Generic;

namespace TesteImpressao
{
    class Program
    {
        static void Main(string[] args)
        {

            string host = "IP";
            int port = 9100;
            string messageImp = "Boa tarde";

            Socket s = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream,
                    ProtocolType.Tcp);

            try
            {

                Console.WriteLine("Estabelecendo conexão com {0}", host);
                s.Connect(host, port);
                Console.WriteLine("Conexão estabelecida com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro na conexão com o servidor. " + e.Message);
            }

            try
            {
                byte[] byData = System.Text.Encoding.ASCII.GetBytes(messageImp);
                s.Send(byData);
                s.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine("Erro ao imprimir. " + e.Message);
            }

            Console.ReadKey();

        }



    }

}