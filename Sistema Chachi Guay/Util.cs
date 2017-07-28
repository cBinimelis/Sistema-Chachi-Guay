using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Chachi_Guay
{
    class Util
    {
        private static Form1  f1;

        public static void setF1(Form1 f1)
        {
            Util.f1 = f1;
        }
        public static Form1 getF1()
        {
            return Util.f1;
        }
    }

    class Usuario
    {
        private static int id_Usuario;
        private static string Nick = "";

        public static void setNick(String Nick)
        {
            Usuario.Nick = Nick;
        }

        public static String getNick()
        {
            return Usuario.Nick;
        }

        public static void setId(int id_Usuario)
        {
            Usuario.id_Usuario = id_Usuario;
        }

        public static int getId()
        {
            return Usuario.id_Usuario;
        }
    }
}
