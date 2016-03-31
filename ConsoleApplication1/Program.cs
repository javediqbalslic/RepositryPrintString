using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Title, fname, mname, lname, pname,T=null,F=null,M=null,L=null,P=null;
            Console. WriteLine("Plz enter  your title Sr/Mrs");
            Title = Console.ReadLine();
            Console.WriteLine("Plz Enter  your First Name");
            fname = Console.ReadLine();
            Console.WriteLine("Plz enter middle name");
            mname = Console.ReadLine();
            Console.WriteLine("Plz Enter Last name");
            lname = Console.ReadLine();
            Console.WriteLine("Plz enter ur protocaol Name loike Sb/Khan/Ch");
            pname = Console.ReadLine();
           string a= string.Empty;
            if(Title!= a)
            {
                
                T = Title+=" ";
                //Console.Write(Title+" ");
            }
            if(fname!= a)
            {
                F = fname+=" ";
               // Console.Write(fname+" ");
            }
            if(mname!= a)
            {
                M = mname+=" ";
              //Console.Write(mname+" ");
            }
            if(lname!= a)
            {
                L = lname+=" ";
                //Console.Write(lname+" ");
            }
            if(pname!= a)
            {
               P = pname+=" ";
                //Console.Write(pname+" ");
            }


         // Console.WriteLine( " "+T+" "+F+" "+M+" "+L+" "+P);
           Console.WriteLine(T + F + M + L + P);
            Console.WriteLine("{0}{1}{2}{3}{4}",T,F,M,L,P);


            //Console.Write(Title +" "+ fname+" " + mname +" "+ lname +" "+ pname);
            Console.ReadKey();


        }
    }
}
