using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace calculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    class Solver
    {
        float sol;
        int exp_len;
        string S;
        public Solver()
        { S = ""; exp_len = 0; }
        public float Sol { get { return sol; } }
        public Solver(string exp)
        { S = exp; exp_len = S.Length; }
        public bool scanForBrackets(ref int st, ref int end)
        {

            const int len = 20;
            for (int j = 0; j < exp_len; j++)
            {
                if (S[j] == '(')
                {
                    st = j;
                    for (int i = j + 1; i < exp_len; i++)
                        if (S[i] == ')')
                            end = i;
                    return true;
                }
            }
            return false;
        }
        public float parseAndSolve(string exp)
        {

            const int len = 20;
            char[] exp_stack = new char[len];
            string[] number_stack = new string[len];
            string[] final_stack = new string[len];
            for (int j = 0; j < len; j++)
                exp_stack[j] = '\0';
            for (int j = 0; j < len; j++)
                number_stack[j] = "";
            for (int j = 0; j < len; j++)
                final_stack[j] = "";
            int k = exp.Length;
            for (int j = 0; j < k; j++)
                exp_stack[j] = exp[j];

            int i = 0;
            for (int ind = 0; ind < len; ind++)
            {
                if (exp_stack[ind] >= '0' && exp_stack[ind] <= '9')
                {
                    int j;
                    bool dec = false;
                    float d = 10;
                    string m;
                    float mm;
                    string n = exp_stack[ind].ToString();
                    float num = Convert.ToSingle(n);
                    for (j = ind + 1; j < len; j++)
                    {
                        if (exp_stack[j] >= '0' && exp_stack[j] <= '9' && !dec) { m = exp_stack[j].ToString(); mm = Convert.ToSingle(m); num = num * 10 + mm; }
                        else if (exp_stack[j] == '.') dec = true;
                        else if (exp_stack[j] >= '0' && exp_stack[j] <= '9' && dec) { m = exp_stack[j].ToString(); mm = Convert.ToSingle(m); num += mm / d; d = d * 10; }
                        else break;
                    }

                    number_stack[i++] = num.ToString();
                    ind = j;
                }

                if (exp_stack[ind] == '+' || exp_stack[ind] == '-' || exp_stack[ind] == '*' || exp_stack[ind] == '/')
                    number_stack[i++] = exp_stack[ind].ToString();
            }
            /* string temp = "";
             for (int p = 0; p < (len / 2) ; p++)
             {
                 temp = number_stack[p];
                 number_stack[p] = number_stack[len - p - 1];
                 number_stack[len - p - 1] = temp;
             }*/

            for (int ii = 0; ii < len; ii++)
            {
                Console.WriteLine("value {0}: {1}", ii.ToString(), number_stack[ii]);
            }

            /* int exp_len = 0;
             for (int j = 0; j < len; j++)
             {
                 if (number_stack[j] != "") exp_len++;
             }
             Console.WriteLine("\nExp len: {0}", exp_len.ToString());*/
            Console.Read();

            int fin_ind = 0;
            for (int j = 0; j < len; j++)
            {
                if (number_stack[j] != "*" && number_stack[j] != "/")
                {
                    final_stack[fin_ind++] = number_stack[j];
                }
                else
                {
                    string opr = number_stack[j];
                    fin_ind -= 1;
                    float a = Convert.ToSingle(final_stack[fin_ind]);
                    float b = Convert.ToSingle(number_stack[j + 1]);
                    float ans = 0;
                    if (opr == "*") ans = a * b;
                    if (opr == "/") ans = a / b;
                    //        
                    final_stack[fin_ind++] = Convert.ToString(ans);
                    j++;
                }

            }
            for (int ii = 0; ii < len; ii++)
            {
                Console.WriteLine("value {0}: {1}", ii.ToString(), final_stack[ii]);
            }
           // Console.ReadKey();
            int q = 1;
            float answer = Convert.ToSingle(final_stack[0]);
            while (final_stack[q] != "")
            {
                string opr = final_stack[q];
                float op2 = Convert.ToSingle(final_stack[q + 1]);
                if (opr == "+") answer += op2;
                else if (opr == "-") answer -= op2;
                q += 2;
            }
            return answer;
        }
        public void solve()
        {
            const int len = 20;
            int s = 0;
            int e = 0;
            if (!scanForBrackets(ref s, ref e)) sol = parseAndSolve(S);
            else
            {
                string part_exp = S.Substring(s + 1, e - s - 1);
                Solver new_solver = new Solver(part_exp);
                new_solver.solve();
                float sub = new_solver.Sol;
                string new_exp = "";
                string first = S.Substring(0, s);
                string last = S.Substring(e + 1, exp_len - e - 1);
                new_exp = string.Concat(string.Concat(first, sub.ToString()), last);
                sol = parseAndSolve(new_exp);
            }
        }


    }
}
