using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace encontro_remoto_2.Class
{
    public static class Utils
    {
        public static void TextoInicial()
        {
                       
            Console.Clear();
            Console.WriteLine(@$"
            |==============================|
            |------------------------------|
            |----Sistema de Cadastro de----|
            |---Pessoa Física e Jurídica---|
            |------------------------------|
            |==============================|
            |------------------------------|
            |--Selecione a opção desejada--|
            |------------------------------|
            |----1: Pessoa Física ---------|
            |----2: Pessoa Jurídica -------|
            |------------------------------|
            |==============================|
            ");
        }
        public static void TextoPessoaFisica()
        {
            PessoaFisica novaPessoaFisica = new PessoaFisica();
            Console.Clear();
            Console.WriteLine(@$"
            |==============================|
            |------------------------------|
            |----Sistema de Cadastro de----|
            |---------Pessoa Física--------|
            |------------------------------|
            |==============================|
            |------------------------------|
            |--Selecione a opção desejada--|
            |------------------------------|
            |----1: Cadastrar Endereço-----|
            |----2: Dados Pessoais---------|
            |------------------------------|
            |==============================|
            ");

            caseInvalid:

            string? options = Console.ReadLine();

            switch(options)
            {
                case "1":
                    CadastrarEndereco();
                    break;
                case "2":
                    Console.WriteLine($"opcao 2");                    
                    break;
                case "0":
                    Console.WriteLine($"Obrigado por utilizar nosso Sistema.");
                    Utils.BarraCarregamento(false, "finalizando", 8);
                    break;
                default:
                    Console.WriteLine($"Valor inválido... Digite uma opção valida: ");
                    goto caseInvalid;
            }
        }
        
        public static void TextoPessoaJuridica()
        {
            PessoaJuridica novaPessoaJuridica = new PessoaJuridica();
            Console.Clear();
            Console.WriteLine(@$"
            |==============================|
            |------------------------------|
            |----Sistema de Cadastro de----|
            |---------Pessoa Jurídica------|
            |------------------------------|
            |==============================|
            |------------------------------|
            |--Selecione a opção desejada--|
            |------------------------------|
            |----1: Cadastrar Endereço-----|
            |----2: Cadastrar CNPJ---------|
            |------------------------------|
            |==============================|
            ");

            caseInvalid:

            string? options = Console.ReadLine();

            switch(options)
            {
                case "1":
                    CadastrarEndereco();
                    break;
                case "2":
                    caseCnpjInvalid:
                    Console.WriteLine($"Digite seu CNPJ: ");
                    string? cnpj = Console.ReadLine();
                    if (Utils.ValidarCnpj(cnpj))
                    {
                        novaPessoaJuridica.cnpj = cnpj;
                        Console.WriteLine($"Valor cadastrado com sucesso. Deseja realizar outra operação? (s/n)");
                        string? opcao = Console.ReadLine();
                        if (opcao == "s" || opcao == "sim")
                        {   
                            Utils.start();
                        } else if (opcao == "n" || opcao == "nao" || opcao == "não")
                        {
                            Utils.BarraCarregamento(false, "finalizando", 8);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"CNPJ inválido. Digite novamente:");
                        goto caseCnpjInvalid;                        
                    }                                        
                    break;
                case "0":
                    Console.WriteLine($"Obrigado por utilizar nosso Sistema.");
                    Utils.BarraCarregamento(false, "finalizando", 8);
                    break;
                default:
                    Console.WriteLine($"Valor inválido... Digite uma opção valida: ");
                    goto caseInvalid;
            }
        }
        public static void CadastrarEndereco()
        {
            
            Endereco novoEndereco = new Endereco();

            dadosIncorretos:

                Console.WriteLine($"Digite o Logradouro: ");            
                string? logradouro = Console.ReadLine();  
                novoEndereco.logradouro = logradouro;

                Console.WriteLine($"Digite o Bairro: ");            
                string? bairro = Console.ReadLine();
                novoEndereco.bairro = bairro;

                Console.WriteLine($"Digite o Complemento: ");            
                string? complemento = Console.ReadLine();
                novoEndereco.complemento = complemento;
                
                Console.WriteLine($"Digite o Número: ");            
                string? numeroSemFormatacao = Console.ReadLine();
                int numero = Convert.ToInt16(numeroSemFormatacao);
                novoEndereco.numero = numero;

                Console.WriteLine($"O Endereço é comercial?(s: sim/ any: não): ");

                string? endComercialSemFormatacao = Console.ReadLine();
                bool endComercial;

                if (endComercialSemFormatacao == "s")
                {
                    endComercial = true;
                }
                else 
                {
                    endComercial = false;
                }

                novoEndereco.endComercial = endComercial;

                Console.WriteLine(@$"
                Confirme os dados inseridos:

                Logradouro: {novoEndereco.logradouro}.
                Bairro: {novoEndereco.bairro}.
                Número: {novoEndereco.numero}.
                Complemento: {novoEndereco.complemento}.
                Endereço Comercial?: {endComercial};

                Os dados estão corretos? (s: sim/ any: não)
                ");           

                string? options = Console.ReadLine();
                if (options != "s")
                {
                    goto dadosIncorretos;
                }
                else
                {
                    Utils.TextoPessoaJuridica();
                }
            
        }
        public static void BarraCarregamento(bool start, string etapa, int repeticao)
        {
            Console.BackgroundColor = start ? ConsoleColor.Green : ConsoleColor.Red;
            Console.Write(etapa.ToUpper());

            for (var i = 0; i < repeticao; i++)
            {
                Console.Write("_");
                Thread.Sleep(300);
            }
            Console.Write("!");
            Thread.Sleep(600);
            Console.ResetColor();            
        }
        public static void start()
        {
            Utils.BarraCarregamento(true, "iniciando", 8);
            Utils.TextoInicial();

            caseInvalid:

            string? options = Console.ReadLine();

            switch (options)
            {
                case "1":
                    Utils.TextoPessoaFisica();
                    break;
                case "2":
                    Utils.TextoPessoaJuridica();
                    break;
                case "0":
                    Console.WriteLine($"Obrigado por utilizar nosso Sistema.");
                    Utils.BarraCarregamento(false, "finalizando", 8);  
                    break;
                default:
                    Console.WriteLine($"Valor inválido... Digite uma opção valida: ");
                    goto caseInvalid;  
            }
        }   
        public static bool ValidarCnpj(string? cnpj)                          
        {
            if (cnpj is not null)
            {
                if (cnpj.Length == 14)
                {
                    bool isValid = Regex.IsMatch(cnpj, @"^\d{14}|(\d{2}.\d{3}.\d{3}/d{4}-\{2})$");
                    if (isValid)
                    {
                        string substringCnpj = cnpj.Substring(8, 4);
                        if (substringCnpj == "0001")
                        {
                            return true;
                        }                
                    }
                } else if (cnpj.Length == 18)
                {
                    string substringCnpjMascara = cnpj.Substring(11, 4);
                    {
                        
                        if (substringCnpjMascara == "0001")
                        {
                            return true;
                        }                
                    }
                }
            } else {
                Console.WriteLine($"Valor inválido. Encerrando o sistema ");
                Utils.BarraCarregamento(false, "encerrando", 8);                
            }            
            return false;
        }
    }
}