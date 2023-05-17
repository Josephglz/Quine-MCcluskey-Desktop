using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoTabularC
{
    public class QM
    {

        private int VARIABLES;
        private string dontcares;

        public QM(int a)
        {
            VARIABLES = a;
            dontcares = new string('-', a);
        }

        public List<string> GetVars()
        {
            List<string> v = new List<string>();
            string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H" };
            for (int i = 0; i < VARIABLES; i++)
                v.Add(letters[i]);

            return v;
        }

        public string DecToBin(int n)
        {
            if (n == 0)
                return n.ToString();

            if (n % 2 == 0)
                return DecToBin(n / 2) + "0";
            else
                return DecToBin(n / 2) + "1";
        }

        public string Pad(string bin)
        {
            int max = VARIABLES - bin.Length;
            for (int i = 0; i < max; i++)
                bin = "0" + bin;
            return bin;
        }

        public bool IsGreyCode(string a, string b)
        {
            int flag = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    flag++;
            }
            return (flag == 1);
        }

        public string ReplaceComplements(string a, string b)
        {
            string temp = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    temp = temp + "-";
                else
                    temp = temp + a[i];
            }

            return temp;
        }

        public bool InVector(List<string> a, string b)
        {
            return a.Contains(b);
        }

        public List<string> Reduce(List<string> minterms)
        {
            List<string> newminterms = new List<string>();

            int max = minterms.Count;
            int[] checkedArray = new int[max];
            for (int i = 0; i < max; i++)
            {
                for (int j = i; j < max; j++)
                {
                    if (IsGreyCode(minterms[i], minterms[j]))
                    {
                        checkedArray[i] = 1;
                        checkedArray[j] = 1;
                        string complement = ReplaceComplements(minterms[i], minterms[j]);
                        if (!InVector(newminterms, complement))
                            newminterms.Add(complement);
                    }
                }
            }

            for (int i = 0; i < max; i++)
            {
                if (checkedArray[i] != 1 && !InVector(newminterms, minterms[i]))
                    newminterms.Add(minterms[i]);
            }

            return newminterms;
        }

        public string GetValue(string a)
        {
            string temp = "";
            List<string> vars = GetVars();
            if (a == dontcares)
                return "1";

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != '-')
                {
                    if (a[i] == '0')
                        temp = temp + vars[i] + "\u0305";
                    else
                        temp = temp + vars[i];
                }
            }

            return temp;
        }

        public bool VectorsEqual(List<string> a, List<string> b)
        {
            if (a.Count != b.Count)
                return false; a.Sort();
            b.Sort();
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] != b[i])
                    return false;
            }

            return true;
        }
    }
}
