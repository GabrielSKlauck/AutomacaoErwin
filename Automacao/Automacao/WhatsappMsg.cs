using EasyAutomationFramework;
using Newtonsoft.Json.Bson;
using OpenQA.Selenium;
using org.bouncycastle.asn1.cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automacao
{
    public class WhatsappMsg : Web
    {
        private static bool carregado = false;
        public WhatsappMsg()
        {
            carregarWhats();
        }

        public void SendMessage(string message, string to)
        {
            carregarPessoa(to);
            if (carregado)
            {
                var elementMessage = AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div[2]/div[1]", message);

                elementMessage.element.SendKeys(Keys.Enter);
            }

            
        }

        private void carregarPessoa(string to)
        {
            if (!carregado)
            {
                var elementSearch = AssignValue(TypeElement.Xpath, "//*[@id=\"side\"]/div[1]/div/div[2]/div[2]/div/div[1]/p", to);

                elementSearch.element.SendKeys(Keys.Enter);

                carregado = true;
            }
            
        }

        private void carregarWhats()
        {
            StartBrowser(TypeDriver.GoogleChorme, "C:\\Users\\SeuUsuario\\AppData\\Local\\Google\\Chrome\\User Data");

            Navigate("https://web.whatsapp.com/");

            WaitForLoad();

            Thread.Sleep(TimeSpan.FromSeconds(8));
        }
    }
}
