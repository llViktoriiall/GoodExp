using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace GoodExp
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string text = " ";
        List<string> lst2 = new List<string>();
        List<string> vars = new List<string>();
        List<string> varsmeans = new List<string>();        
        


        public void tree()
        {
            int lvl = 0;
            List<string> lst = new List<string>();
            lst = lst2;
            for (int i = 0; i < lst.Count; ++i)
            {
                if (lst[i] == "/" || lst[i] == "/\n" || lst[i] == "/\n\n" || lst[i] == "\n/\n")
                {
                    lvl++;
                }
            }
            int tabs = 0;
            for (int i =0;i<lst.Count;++i)
            {
                if(lst[i] == "/" || lst[i] == "/\n" || lst[i] == "/\n\n" || lst[i] == "\n/\n")
                {
                    for(int k =0;k< tabs;++k)
                    {
                        richTextBox2.Text = richTextBox2.Text + "\t";
                    }
                    richTextBox2.Text = richTextBox2.Text + "brackets\n";
                    tabs++;
                }
                if(lst[i] == "class")
                {
                    for (int k = 0; k < tabs; ++k)
                    {
                        richTextBox2.Text = richTextBox2.Text + "\t";
                    }
                    richTextBox2.Text = richTextBox2.Text + "class\n";
                    tabs++;
                    for (int k = 0; k < tabs; ++k)
                    {
                        richTextBox2.Text = richTextBox2.Text + "\t";
                    }
                    richTextBox2.Text = richTextBox2.Text + "identifier : Pattern\n";
                    tabs--;
                }
                if(lst[i] == "new")
                {
                    for (int k = 0; k < tabs; ++k)
                    {
                        richTextBox2.Text = richTextBox2.Text + "\t";
                    }
                    richTextBox2.Text = richTextBox2.Text + "initialization\n";
                    tabs++;
                    for (int k = 0; k < tabs; ++k)
                    {
                        richTextBox2.Text = richTextBox2.Text + "\t";
                    }
                    richTextBox2.Text = richTextBox2.Text + "identifier : ";
                    string[] temp = lst[i + 1].Split(new Char[] { '|' });
                    richTextBox2.Text = richTextBox2.Text + temp[0] + "\n";
                    for (int k = 0; k < tabs; ++k)
                    {
                        richTextBox2.Text = richTextBox2.Text + "\t";
                    }
                    richTextBox2.Text = richTextBox2.Text + "string : ";
                    richTextBox2.Text = richTextBox2.Text + temp[1] + "\n";
                    tabs--;
                }
                if(lst[i] == "fa" || lst[i] == "ff" || lst[i] == "fl")
                {
                    for (int k = 0; k < tabs; ++k)
                    {
                        richTextBox2.Text = richTextBox2.Text + "\t";
                    }
                    richTextBox2.Text = richTextBox2.Text + "function find call\n";
                    tabs++;
                    for (int k = 0; k < tabs; ++k)
                    {
                        richTextBox2.Text = richTextBox2.Text + "\t";
                    }
                    string check = lst[i + 1];
                    if(check[0] != '|')
                    {
                        richTextBox2.Text = richTextBox2.Text + "identifier : ";
                        string[] temp = lst[i + 1].Split(new Char[] { '.', ';','\n' });
                        richTextBox2.Text = richTextBox2.Text + temp[0] + "\n";
                        for (int k = 0; k < tabs; ++k)
                        {
                            richTextBox2.Text = richTextBox2.Text + "\t";
                        }
                        richTextBox2.Text = richTextBox2.Text + "method : ";
                        richTextBox2.Text = richTextBox2.Text + temp[1] + "\n";
                        tabs--;
                    }
                    else
                    {
                        richTextBox2.Text = richTextBox2.Text + "string : ";
                        string[] temp = lst[i + 1].Split(new Char[] { '|', ';','\n' });
                        richTextBox2.Text = richTextBox2.Text + temp[1] + "\n";
                        tabs--;
                    }
                }
                if(lst[i] == "message")
                {
                    for (int k = 0; k < tabs; ++k)
                    {
                        richTextBox2.Text = richTextBox2.Text + "\t";
                    }
                    richTextBox2.Text = richTextBox2.Text + "function message\n";
                    tabs++;
                    for (int k = 0; k < tabs; ++k)
                    {
                        richTextBox2.Text = richTextBox2.Text + "\t";
                    }
                    richTextBox2.Text = richTextBox2.Text + "string : ";
                    string[] temp = lst[i + 1].Split(new Char[] { '|' });
                    richTextBox2.Text = richTextBox2.Text + temp[1] + "\n";
                    tabs--;
                }
                if(lst[i] == "if")
                {
                    for (int k = 0; k < tabs; ++k)
                    {
                        richTextBox2.Text = richTextBox2.Text + "\t";
                    }
                    richTextBox2.Text = richTextBox2.Text + "if\n";
                    tabs++;
                    for (int k = 0; k < tabs; ++k)
                    {
                        richTextBox2.Text = richTextBox2.Text + "\t";
                    }
                    richTextBox2.Text = richTextBox2.Text + "condition : ";
                    richTextBox2.Text = richTextBox2.Text + lst[i+1] + "\n";
                    tabs--;
                }
                if (lst[i] == "then")
                {
                    for (int k = 0; k < tabs; ++k)
                    {
                        richTextBox2.Text = richTextBox2.Text + "\t";
                    }
                    richTextBox2.Text = richTextBox2.Text + "then\n";
                }
                if (lst[i] == "else")
                {
                    for (int k = 0; k < tabs; ++k)
                    {
                        richTextBox2.Text = richTextBox2.Text + "\t";
                    }
                    richTextBox2.Text = richTextBox2.Text + "else\n";
                }
                if(lst[i] == "cycle")
                {
                    for (int k = 0; k < tabs; ++k)
                    {
                        richTextBox2.Text = richTextBox2.Text + "\t";
                    }
                    richTextBox2.Text = richTextBox2.Text + "cycle\n";
                    tabs++;
                    for (int k = 0; k < tabs; ++k)
                    {
                        richTextBox2.Text = richTextBox2.Text + "\t";
                    }
                    richTextBox2.Text = richTextBox2.Text + "condition: ";
                    richTextBox2.Text = richTextBox2.Text + lst[i+1] + "\n";
                    tabs--;
                }
            }
        }



        //ого, маєш класну функцію для парсера
        public void make_var(int i)
        { 
            string var = lst2[i + 1];
            string[] word = var.Split(new Char[] { ':', ';', '|' });
            vars.Add(word[0]);
            varsmeans.Add(word[1]);
        }

        public bool make_pattern(int i, char f)
        {
            richTextBox6.Text = richTextBox6.Text + "searching...\n";
            int variativs_counter = 0;
            List<int> splits = new List<int>();
            List<int> ends = new List<int>();
            List<int> variativs = new List<int>();
            List<char> arr = new List<char>();
            string pattern = lst2[i + 1];
            richTextBox4.Text = richTextBox4.Text + pattern + "\n";
            List<string> searchers = new List<string>();
            string search = "";
            int count = 0;
            if (pattern[0] != '|')
            {
                string var = pattern;
                string[] word = var.Split(new Char[] { '.', ';'});
                int l;
                for(l = 0;l<vars.Count;++l)
                {
                    if(word[0] == vars[l])
                    {
                        pattern = '|' + varsmeans[l] + '|';
                    }
                }
                if (word[1] == "lower")
                {
                    pattern = pattern.ToLower();
                }
                else if(word[1] == "upper")
                {
                    pattern = pattern.ToUpper();
                }
            }
            for (int k = 1; k < pattern.Length; ++k)
            {
                int split_pos = 0;
                if (Char.IsLetterOrDigit(pattern[k]))
                {
                    search += pattern[k];
                }
                else if(pattern[k] == '_')
                {
                    search += ' ';
                }
                else if (pattern[k] == '{')
                {
                    k++;
                    while (pattern[k] != '}')
                    {
                        search += pattern[k];
                        k++;
                    }
                }
                else if (pattern[k] == '(')
                {
                    split_pos = k;
                    splits.Add(split_pos);
                    while (pattern[k] != ')')
                    {
                        if (pattern[k] == ',')
                        {
                            variativs_counter++;
                            string s1 = search;
                            s1 += pattern[k - 1];
                            searchers.Add(s1);
                            if (pattern[k + 2] != ',')
                            {
                                string s2 = search;
                                s2 += pattern[k + 1];
                                variativs_counter++;
                                searchers.Add(s2);
                            }
                        }
                        else if (pattern[k] == '-')
                        {
                            arr.Add(pattern[k - 1]);
                            arr.Add(pattern[k + 1]);
                            char t = ' ';
                            string r = "";
                            t = pattern[k - 1];
                            while (t != pattern[k + 1])
                            {
                                r = search + t;
                                t++;
                                searchers.Add(r);
                                variativs_counter++;
                            }
                            t = pattern[k + 1];
                            r = search + t;
                            searchers.Add(r);
                            variativs_counter++;
                        }
                        else if(pattern[k] == '*')
                        {
                            if(pattern[k+1] == 'd')
                            {
                                arr.Add('0');
                                arr.Add('9');
                                char t = ' ';
                                t = '0';
                                string r = "";
                                while (t != ('9'))
                                {                                    
                                    r = search + t;
                                    t++;
                                    searchers.Add(r);
                                    variativs_counter++;
                                }
                                t = '9';
                                r = search + t;
                                searchers.Add(r);
                                variativs_counter++;
                            }
                            else if (pattern[k + 1] == 'l')
                            {
                                arr.Add('a');
                                arr.Add('z');
                                char t = ' ';
                                t = 'a';
                                string r = "";
                                while (t != ('z'))
                                {
                                    r = search + t;
                                    t++;
                                    searchers.Add(r);
                                    variativs_counter++;
                                }
                                t = 'z';
                                r = search + t;
                                searchers.Add(r);
                                variativs_counter++;
                            }
                            else if (pattern[k + 1] == 'L')
                            {
                                arr.Add('A');
                                arr.Add('Z');
                                char t = ' ';
                                t = 'A';
                                string r = "";
                                while (t != ('Z'))
                                {
                                    r = search + t;
                                    t++;
                                    searchers.Add(r);
                                    variativs_counter++;
                                }
                                t = 'Z';
                                r = search + t;
                                searchers.Add(r);
                                variativs_counter++;
                            }
                        }
                        k++;
                    }
                    variativs.Add(variativs_counter);
                    variativs_counter = 0;
                }
            }
            searchers.Add(search);
            
            if(searchers.Count > 1)
            {
                for (int k = 0; k < splits.Count; ++k)
                {
                    int pos = variativs[0];          
                    string add = searchers[pos].Substring(splits[k]-1);
                    for (int m = 0; m < variativs[0]; ++m)
                    {
                        searchers[m] += add;
                    }
                }
                searchers.RemoveAt(searchers.Count - 1);
            }
            for (int k = 0; k < searchers.Count; ++k)
            {
                richTextBox4.Text = richTextBox4.Text + searchers[k] + "\n";
            }         
            text = richTextBox5.Text;
            string helper = text;
            int ind = 0;
            bool find = false;
            switch (f)
            {
                case 'f':
                    for(int k =0;k<searchers.Count;++k)
                    {
                        ind = text.IndexOf(searchers[k]);
                        if(ind != -1)
                        {
                            find = true;
                            richTextBox6.Text = richTextBox6.Text + ind + "(" + searchers[k] + ")\n";
                            count++;
                            break;
                        }
                    }
                    break;
                case 'a':                    
                    bool ok = true; 
                    for (int k = 0; k < searchers.Count; ++k)
                    {
                        text = helper;
                        ok = true;
                        while (ok)
                        {
                            ind = text.IndexOf(searchers[k]);
                            if(ind == -1)
                            {
                                ok = false;
                            }
                            else
                            {
                                richTextBox6.Text = richTextBox6.Text + ind + "(" + searchers[k] + ")\n";
                                string temp = text.Substring(searchers[k].Length + ind);
                                text = temp;
                                find = true;
                                count++;
                            }
                        }                        
                    }
                    break;
                case 'l':
                    int max = 0;
                    string m = " ";
                    bool okk = true;
                    for (int k = 0; k < searchers.Count; ++k)
                    {
                        text = helper;
                        okk = true;
                        while (okk)
                        {
                            ind = text.IndexOf(searchers[k]);
                            if(ind > max)
                            {
                                max += ind;
                                m = searchers[k];
                            }
                            if (ind == -1)
                            {
                                okk = false;
                            }
                            else
                            {
                                string temp = text.Substring(searchers[k].Length + ind);
                                text = temp;
                                find = true;
                                count++;
                            }
                        }
                    }
                    richTextBox6.Text = richTextBox6.Text + max + "(" + m + ")\n";
                    break;
            }
            richTextBox6.Text = richTextBox6.Text + "pattern was founded " + count + "times\n";
            richTextBox6.Text = richTextBox6.Text + "\n\n";
            if (find == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        public int operator_cycle(int i)
        {
            string s = lst2[i + 1];
            richTextBox6.Text = richTextBox6.Text + s + "\n";
            string[] word = lst2[i + 1].Split(new Char[] { ',', '|' });
            List<string> lst = new List<string>();
            foreach (string w in word)
            {
                if (w.Trim() != "")
                lst.Add(w);
                richTextBox6.Text = richTextBox6.Text + w + "\n";
            }
            string variable = "";
            string st = "";
            string en = "";
            int start = 0;
            int end;
            string work;
            char check;
            work = lst[0];
            check = work[0];
            int c = 0;
            int diff;
            while(check != '=')
            {
                variable += check;
                c++;
                check = work[c];
            }
            richTextBox6.Text = richTextBox6.Text + variable + " initialized as ";
            c++;
            for(int k=c;k<work.Length;++k)
            {
                check = work[k];
                st += check;
            }
            Int32.TryParse(st, out start);
            richTextBox6.Text = richTextBox6.Text + start + " to ";
            work = lst[1];
            c = st.Length;
            c++;c++;
            for (int k = c; k < work.Length; ++k)
            {
                check = work[k];
                en += check;
            }
            Int32.TryParse(en, out end);
            richTextBox6.Text = richTextBox6.Text + end + "\n";
            if(end>start)
            {
                diff = end - start;
            }
            else
            {
                diff = start - end;
            }
            return diff;
        }



        public bool operator_if(int i, char f)
        {
            string pattern = lst2[i + 1];
            if(pattern == "false")
            {
                if((make_pattern((i+2), 'a'))==false)
                {
                    //richTextBox5.Text = richTextBox5.Text + "YES" + "\n";
                    return true;

                }
                else
                {
                    //richTextBox5.Text = richTextBox5.Text + "NO" + "\n";
                    return false;
                }
            }
            else
            {
                if ((make_pattern((i + 2), 'a')==false))
                {
                    //richTextBox5.Text = richTextBox5.Text + "NO" + "\n";
                    return false;
                }
                else
                {
                    //richTextBox5.Text = richTextBox5.Text + "YES" + "\n";
                    return true;
                }
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            bool mass_bracks = false;
            bool fig_bracks = false;


            //зчитування і спліт стрічки
            string code = richTextBox1.Text;
            List<string> lst = new List<string>();
            string[] word = code.Split(new Char[] { ' ', '\n' });//, ',', '.', ':', '\t'
            int count = 0;
            foreach (string s in word)
            {
                if (s.Trim() != "")
                lst.Add(s);
                ++count;
            }



            //ЛЕКСЕР БОЖЕ СПАСИ
            List<string> tokens = new List<string>();
            int lvl = 0;
            string temp;
            string token = "";
            bool cycle = false;
            bool bracks = false;
            for (int i = 0; i < lst.Count; ++i)
            {
                temp = lst[i];
                switch (temp)
                {
                    case "/":
                        ++lvl;
                        richTextBox3.Text = richTextBox3.Text + "<brackets>\n";
                        token += "/\n";
                        tokens.Add(token);
                        token = "";
                        break;
                    case ":":
                        richTextBox3.Text = richTextBox3.Text + "<start of the func>";
                        break;
                    case "class":
                        richTextBox3.Text = richTextBox3.Text + "<class variables:>";
                        token += "class ";
                        break;
                    case "Pattern":
                        token += "\n";
                        break;
                    case "new":
                        richTextBox3.Text = richTextBox3.Text + "<creating variable: >";
                        token += "new ";
                        break;
                    case "find_first":
                        richTextBox3.Text = richTextBox3.Text + "<call to find_first> ";
                        token += "ff ";
                        break;
                    case "find_last":
                        richTextBox3.Text = richTextBox3.Text + "<call to find_last> ";
                        token += "fl ";
                        break;
                    case "find_all":
                        richTextBox3.Text = richTextBox3.Text + "<call to find_all> ";
                        token += "fa ";
                        break;
                    case "cycle":
                        richTextBox3.Text = richTextBox3.Text + "<call to cycle> ";
                        token += "cycle ";
                        cycle = true;
                        break;
                    case "start":
                        richTextBox3.Text = richTextBox3.Text + "<start cycle> ";
                        token += "\n";
                        break;
                    case "if":
                        richTextBox3.Text = richTextBox3.Text + "<if > ";
                        token += "if ";
                        break;
                    case "then":
                        richTextBox3.Text = richTextBox3.Text + "<then > ";
                        token += " then\n";
                        break;
                    case "else":
                        richTextBox3.Text = richTextBox3.Text + "<else> ";
                        token += "else ";
                        break;
                    case "false":
                        richTextBox3.Text = richTextBox3.Text + "<statement is false> ";
                        token += "false ";
                        break;
                    case "true":
                        richTextBox3.Text = richTextBox3.Text + "<statment is true> ";
                        token += "true ";
                        break;
                    case "message":
                        richTextBox3.Text = richTextBox3.Text + "<call to message> ";
                        token += "message ";
                        break;
                    case "pattern":
                        richTextBox3.Text = richTextBox3.Text + "<new pattern> ";
                        token += "pattern ";
                        break;
                    case "+":
                        richTextBox3.Text = richTextBox3.Text + "<+> ";
                        token += "+ ";
                        break;
                    case "-":
                        richTextBox3.Text = richTextBox3.Text + "<-> ";
                        token += "- ";
                        break;
                    case "\\":
                        richTextBox3.Text = richTextBox3.Text + "<\\> ";
                        token += "\\";
                        break;
                    default:
                        richTextBox3.Text = richTextBox3.Text + "<pattern>\n";
                        string patt = temp;
                        int k;
                            for (k = 0; k < patt.Length; ++k)
                            {
                                if (patt[k] == '(')
                                {
                                    if (fig_bracks)
                                    {
                                        richTextBox3.Text = richTextBox3.Text + "<( as a part of pattern>\n";
                                        token += "(";
                                    }
                                    else
                                    {
                                        if (mass_bracks)
                                        {
                                            richTextBox3.Text = richTextBox3.Text + "<ERROR incorrect start of the mass>\n";
                                        }
                                        else
                                        {
                                            richTextBox3.Text = richTextBox3.Text + "<mass brackets start>\n";
                                            mass_bracks = true;
                                            char test = patt[k + 1];
                                            token += "(";
                                        }
                                    }
                                }
                                else if (Char.IsLetterOrDigit(patt[k]))
                                {
                                    richTextBox3.Text = richTextBox3.Text + "<" + patt[k] + " added to pattern>\n";
                                    token += patt[k];
                                }
                                else if (patt[k] == ',')
                                {
                                    if (fig_bracks)
                                    {
                                        richTextBox3.Text = richTextBox3.Text + "<, as a part of pattern>\n";
                                        token += ",";
                                    }
                                    else
                                    {
                                        if (Char.IsLetterOrDigit(patt[k - 1])|| cycle)
                                        {
                                            richTextBox3.Text = richTextBox3.Text + "<,>\n";
                                            token += ",";
                                        }
                                        else
                                        {
                                            richTextBox3.Text = richTextBox3.Text + "<ERROR incorrect data inside of the enum in mass>\n";
                                        }
                                    }
                                }
                                else if (patt[k] == '_')
                                {
                                    if (fig_bracks)
                                    {
                                        richTextBox3.Text = richTextBox3.Text + "<_ as a part of pattern>\n";
                                        token += "_";
                                    }
                                    else
                                    { 
                                        richTextBox3.Text = richTextBox3.Text + "<_>\n";
                                        token += "_";
                                    }
                                   
                                }
                                else if (patt[k] == '-')
                                {
                                    if (fig_bracks)
                                    {
                                        richTextBox3.Text = richTextBox3.Text + "<- as a part of pattern>\n";
                                        token += "-";
                                    }
                                    else
                                    {
                                        if (Char.IsLetterOrDigit(patt[k - 1]) && Char.IsLetterOrDigit(patt[k + 1]))
                                        {
                                            richTextBox3.Text = richTextBox3.Text + "<->\n";
                                            token += "-";
                                        }
                                        else
                                        {
                                            richTextBox3.Text = richTextBox3.Text + "<ERROR incorrect data inside of the from-to in mass>\n";
                                        }
                                    }
                                }
                                else if (patt[k] == '{')
                                {
                                    if (fig_bracks == false)
                                    {
                                        fig_bracks = true;
                                        richTextBox3.Text = richTextBox3.Text + "<{>\n";
                                        token += "{";
                                    }
                                    else
                                    {
                                        richTextBox3.Text = richTextBox3.Text + "<{ as a part of pattern>\n";
                                        token += "{";
                                    }
                                }
                                else if (patt[k] == '}')
                                {
                                    if (fig_bracks)
                                    {
                                        if (patt[k] == ' ')
                                        {
                                            richTextBox3.Text = richTextBox3.Text + "<} as a part of pattern>\n";
                                            token += "}";
                                        }
                                        else
                                        {
                                            fig_bracks = false;
                                            richTextBox3.Text = richTextBox3.Text + "<}>\n";
                                            token += "}";
                                        }
                                    }
                                    else
                                    {
                                        richTextBox3.Text = richTextBox3.Text + "<ERROR incorrect figure brackets end>\n";
                                    }
                                }
                                else if (patt[k] == '!')
                                {
                                    if (fig_bracks == false)
                                    {
                                        if (patt[k + 1] != '(')
                                        {
                                            richTextBox3.Text = richTextBox3.Text + "<ERROR there is no brackets after !>\n";
                                        }
                                        else
                                        {
                                            richTextBox3.Text = richTextBox3.Text + "<!>\n";
                                            token += "!";
                                        }
                                    }
                                    else
                                    {
                                        richTextBox3.Text = richTextBox3.Text + "<! as a part of pattern>\n";
                                        token += "!";
                                    }
                                }
                                else if (patt[k] == ')')
                                {
                                    if (fig_bracks == true)
                                    {
                                        richTextBox3.Text = richTextBox3.Text + "<( as a part of pattern >\n";
                                        token += ")";
                                    }
                                    else
                                    {
                                        if (mass_bracks)
                                        {
                                            richTextBox3.Text = richTextBox3.Text + "<mass brackets end>\n";
                                            mass_bracks = false;
                                            token += ")";
                                            char test = patt[k + 1];
                                        }
                                        else
                                        {
                                            richTextBox3.Text = richTextBox3.Text + "<ERROR incorrect mass brackets end>\n";
                                        }
                                    }
                                }
                                else if (patt[k] == '|')
                                {
                                    if (fig_bracks == true)
                                    {
                                        richTextBox3.Text = richTextBox3.Text + "<| as a part of pattern >\n";
                                        token += "|";
                                    }
                                    else
                                    { 
                                        if(bracks)
                                        {
                                            bracks = false;
                                        }
                                        else
                                        {
                                            richTextBox3.Text = richTextBox3.Text + "<pattern brackets>\n";
                                            token += "|";
                                        }                                        
                                    }
                                }
                                else if (patt[k] == ';')
                                {
                                    if (fig_bracks == true)
                                    {
                                        richTextBox3.Text = richTextBox3.Text + "<; as a part of pattern >\n";
                                        token += ";";
                                    }
                                    else
                                    {
                                        if(cycle)
                                        {
                                            token += ";";
                                        }
                                        else
                                        { 
                                            richTextBox3.Text = richTextBox3.Text + "<string of code ended>\n";
                                            token += ";\n";
                                            tokens.Add(token);
                                            token = "";
                                        }
                                    }
                                }
                                else if (patt[k] == '*')
                                {
                                    if (fig_bracks == true)
                                    {
                                        richTextBox3.Text = richTextBox3.Text + "<* as a part of pattern >\n";
                                        token += "*";
                                    }
                                    else
                                    {
                                        richTextBox3.Text = richTextBox3.Text + "<*>\n";
                                        token += "*";
                                    }
                                }
                            else
                            {
                                token += patt[k];
                            }
                        }
                        break;
                }
            }
            //tokens.Add("/");
            for (int i = 0; i < tokens.Count; ++i)
            {
                richTextBox3.Text = richTextBox3.Text + tokens[i] + "\n";
            }


            
            //парсер(9((
            string code_temp;
            for (int i = 0; i < tokens.Count; ++i)
            {
                code_temp = tokens[i];                
                string[] word2 = code_temp.Split(new Char[] { ' ', '\n' });//, ',', '.', ':', '\t'                
                foreach (string s in word2)
                {
                    if (s.Trim() != "")
                        lst2.Add(s);
                }
            }


            //ПОСАДИЛА ДЕРЕВО
            tree();


            string node;
            bool else_check = false;
            int diff = 1;
            bool cyclec = false;
            for (int i = 0; i < lst2.Count; ++i)
            {
                if (cyclec == false)
                {
                    diff = 1;
                }
                node = lst2[i];
                switch (node)
                {
                    case "ff":
                        while(diff > 0)
                        {
                            make_pattern(i,'f');
                            diff--;
                        }                        
                        break;
                    case "fl":
                        while (diff > 0)
                        {
                            make_pattern(i, 'l');
                            diff--;
                        }
                        break;
                    case "fa":
                        while (diff > 0)
                        {
                            make_pattern(i, 'a');
                            diff--;
                        }
                        break;
                    case "if":
                        if(operator_if(i, 'a') == false)
                        {
                            while (lst2[i] != "/")
                            {
                                i++;
                            }
                            i++;
                            while (lst2[i] != "/")
                            {
                                i++;
                            }
                            else_check = true;
                        }
                        else
                        {
                            while (lst2[i] != "/")
                            {
                                i++;
                            }
                            else_check = false;
                        }
                        break;
                    case "else":
                        if(else_check == false)
                        {
                            while (lst2[i] != "/")
                            {
                                i++;
                            }
                            i++;
                            while (lst2[i] != "/")
                            {
                                i++;
                            }
                        }
                        break;
                    case "cycle":
                        diff = operator_cycle(i);
                        i+=2;
                        cyclec = true;
                        break;
                    case "/":
                        diff = 1;
                        cyclec = false;
                        break;
                    case "new":
                        make_var(i);
                        break;
                    case "message":
                        while (diff > 0)
                        {                        
                            string[] word1 = lst2[i+1].Split(new Char[] { '|', ';' });
                            richTextBox6.Text = richTextBox6.Text + word1[1];
                            diff--;
                        }
                        break;
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
