using encontro_remoto_2.Class;

// Endereço
Endereco novoEnderecoPessoaFisica = new Endereco();

novoEnderecoPessoaFisica.logradouro = "Rua Verona";
novoEnderecoPessoaFisica.bairro = "Pagani";
novoEnderecoPessoaFisica.complemento = "Casa";
novoEnderecoPessoaFisica.numero = 111;
novoEnderecoPessoaFisica.endComercial = false;

// Pessoa Física
PessoaFisica novaPf = new PessoaFisica();

novaPf.dataNasc = new DateTime(1992,05,23);
novaPf.nome = "Eduardo";
novaPf.rendimento = 6000;

bool dataNascValidada = novaPf.ValidarDataNascimento(novaPf.dataNasc);

float impostoCalculadoPessoaFisica = novaPf.CalcularImposto(novaPf.rendimento);

Console.WriteLine(@$"
Nome: {novaPf.nome}
Maior de Idade: {dataNascValidada}
--ENDEREÇO--
Rua: {novoEnderecoPessoaFisica.logradouro}
Número: {novoEnderecoPessoaFisica.numero}
Bairro: {novoEnderecoPessoaFisica.bairro}
Complemento: {novoEnderecoPessoaFisica.complemento}
Endereço Comercial?: {novoEnderecoPessoaFisica.endComercial}
Valor do imposto com rendimento de {novaPf.rendimento.ToString("C")}: {impostoCalculadoPessoaFisica.ToString("C")}
");


// Pessoa Jurídica
PessoaJuridica novaPj = new PessoaJuridica();
novaPj.rendimento = 15000;
float impostoCalculadoPessoaJuridica = novaPj.CalcularImposto(novaPj.rendimento);
