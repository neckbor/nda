using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Интерпретатор
{

    // В = Т | В+Т | В-Т
    // Т = Э | Т*Э
    // Э = Ч | (В)


    public class Node
    {
        private int value;
        private string op;
        public Node left;
        public Node right;
        public Node(int value) //ввод значения
        {
            this.value = value;
            this.op = "";
            left = null;
            right = null;
        }
        public Node(string op) //вод операции
        {
            this.value = 0;
            this.op = op;
            left = null;
            right = null;
        }
        public int Compute()
        {
            if (op == "") return value;
            int L = left.Compute();
            int R = right.Compute();
            if (op == "+") return L + R;
            if (op == "-") return L - R;
            if (op == "*") return L * R;
            throw new Exception("Ошибка Compute()");
        }
    }

    public class Parser
    {
        public class nErrorException : Exception
        {
            public int position { get; private set; }
            public nErrorException(int pos, string Message) : base(Message)
            {
                position = pos;
            }
            public nErrorException(string Message) : base(Message)
            {

            }
        }

        private Node _root;

        public double Compute()
        {
            if (_root == null) throw new nErrorException("Ошибка");
            
            return _root.Compute();
        }

        public void Parse(string s)
        {

            int pos = s.Length - 1;
            _root = ParseExpression(s, ref pos);
            if (pos > 0) throw new nErrorException("Неверно расставлены скобки");
        }

        private Node ParseExpression(string s, ref int pos)
        {
            if (pos == -1) throw new nErrorException("Ошибка");

            Node R = ParseTerm(s, ref pos);
            if (pos <= 0) return R;
            pos--;
            string op = s.Substring(pos, 1);
            
            if (op == "+" || op == "-")
            {
                pos--;
                Node L = ParseExpression(s, ref pos);
                Node p = new Node(op);
                p.left = L;
                p.right = R;
                return p;
            }
            //else
            //    pos++;
            return R;
        }

        private Node ParseTerm(string s, ref int pos)
        {
            if (pos == -1) throw new nErrorException("Ошибка");
            Node R = ParseElement(s, ref pos);
            
            if (pos <= 0) return R;

            pos--;
            string op = s.Substring(pos, 1);

            if (op == "*")
            {
                pos--;
                Node L = ParseTerm(s, ref pos);
                Node p = new Node(op);
                p.left = L;
                p.right = R;
                return p;
            }
            else
                pos++;
            return R;
        }

        private Node ParseElement(string s, ref int pos)
        {
            if (pos == -1) throw new nErrorException(pos, "Введно неверное выражение");
            if (s[pos] == ')')
            {

                pos--;
                Node Q = ParseExpression(s, ref pos);
                pos--;

                if (pos == -1 || (pos != 0 && int.TryParse(s[pos - 1].ToString(), out int q))) throw new nErrorException(pos, "Неверно расставлены знаки");
                if (pos == -1 || s[pos] != '(') throw new nErrorException(pos, "Неверно расставлены скобки");

                return Q;
            }
            return ParseNumber(s, ref pos);
        }

        private Node ParseNumber(string s, ref int pos)
        {
            if (pos == -1) throw new nErrorException("Ошибка");
            int result = 0;
            string num = "";
            while (true)
            {
                string op = s.Substring(pos, 1);
                if (!int.TryParse(op, out result))
                {
                    break;
                }
                if (pos == 0)
                {
                    num += op;
                    break;
                }
                num += op;
                pos--;
            }
            pos++;
            num = Utils.ReverseString(num);
            if (int.TryParse(num, out int r))
            {
                Node q = new Node(int.Parse(num));
                return q;
            }
            else throw new nErrorException(pos, "Неверно расставлены знаки");
        }

        private Node ParseNumeric(string s, ref int pos)
        {
            if (pos == -1) throw new nErrorException(pos, "Ошибка");
            int res;
            string op = s.Substring(pos, 1);
            if (int.TryParse(op, out res))
            {
                Node p = new Node(int.Parse(op));
                return p;
            }
            else throw new nErrorException(pos, "Неверно расставлены знаки");
        }
    }
}