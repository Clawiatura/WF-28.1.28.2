using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_28._1._28._2
{
    internal class GenPass
    {
        private string? logginUsser;
        private string? loggin;
        private char password;
        public GenPass (string? loggin, string? logginUsser,char password)
        {
            this.logginUsser = logginUsser;
            this.loggin = loggin;
            this.password = password; 
        }
        public string getLogginUsser() => logginUsser!;
        public string getloggin() => loggin!;
        public char getPassword() => password!;
        public void setLogginUsser(string name) => this.logginUsser = name;
        public void setLoggin(string lg) => this.loggin = lg;
        public void setPassword(char p) => this.password = p;

    }
}

