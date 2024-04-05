using System;

namespace Atividade
{  
      public class Program
        {
            static void Main(string[] args)
            {
                float val_pag;
                Console.WriteLine("Imfomar Nome");
                string var_name = Console.ReadLine();
                Console.WriteLine("Infomar Endereco");
                string var_endereco = Console.ReadLine();
                Console.WriteLine("Pessoa Fisica(f) ou Pessoa Juridica(j) ?");
                string var_tipo = Console.ReadLine();
                
                if(var_tipo == "f")
                {
                    Pessoa_Fisica pf = new Pessoa_Fisica();
                    pf.name = var_name;
                    pf.endereco = var_endereco;
                    Console.WriteLine("Infomar CPF:");
                    pf.cpf = Console.ReadLine();
                    Console.WriteLine("Imfomar RG:");
                    pf.rg =  Console.ReadLine();
                    Console.WriteLine("Imfomar Valor da Compra:");
                    val_pag = float.Parse(Console.ReadLine());
                    pf.Pagar_imposto(val_pag);
                    Console.WriteLine("------Pessoa Fisica------");
                    Console.WriteLine("Nome..........:" + pf.name);
                    Console.WriteLine("Endereco.........:" + pf.endereco);
                    Console.WriteLine("CPF..........:" + pf.cpf);
                    Console.WriteLine("RG..........:" + pf.rg);
                    Console.WriteLine("Valor da Compra:" + pf.valor.ToString("C"));
                    Console.WriteLine("Imposto.......:" + pf.valor_imposto.ToString("C"));
                    Console.WriteLine("Total a Pagar:" + pf.total.ToString("C"));
                }
                if(var_tipo == "j")
                {
                    Pessoa_Juridica pj = new Pessoa_Juridica ();
                    pj.name = var_name;
                    pj.endereco = var_endereco;
                    Console.WriteLine("Infomar CNPJ");
                    pj.cnpj = Console.ReadLine();
                    Console.WriteLine("Infomar IE");
                    pj.ie = Console.ReadLine();
                    Console.WriteLine("Infomar Valor da Compra");
                    val_pag = float.Parse(Console.ReadLine());
                    pj.Pagar_imposto(val_pag);
                    Console.WriteLine("------Pessoa Juridica------");
                    Console.WriteLine("Nome..........:" + pj.name);
                    Console.WriteLine("Endereco.........:" + pj.endereco);
                    Console.WriteLine("CNPJ..........:" + pj.cnpj);
                    Console.WriteLine("IE..........:" + pj.ie);
                    Console.WriteLine("Valor da Compra:" + pj.valor.ToString("C"));
                    Console.WriteLine("Imposto.......:" + pj.valor_imposto.ToString("C"));
                    Console.WriteLine("Total a Pagar:" + pj.total.ToString("C"));
            }
        }
    }
}