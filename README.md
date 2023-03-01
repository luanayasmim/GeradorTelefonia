# Gera números

## Desafio feito com o objetivo de criar uma classe que seja capaz de gerar números de telefone válidos. As regras a serem seguidas são as seguintes:

1.	Essa classe deve possuir um método em específico a ser chamado, recebendo todos os tipos de configurações possíveis como argumentos;
2.	O método deve retornar apenas um número de telefone por vez, sendo responsabilidade de quem for usar chamá-lo quantas vezes quiser;
3.	O método deve ser capaz de gerar um número de telefone válido para cada um dos seguintes tipos:
o	Móvel Celular: https://www.gov.br/anatel/pt-br/regulado/numeracao/tabela-servico-movel-celular (Formato: 9XXXX-XXXX)
o	Fixo comutado: https://www.gov.br/anatel/pt-br/regulado/numeracao/tabela-servico-telefonico-fixo-comutado (Formato: 2XXX-XXXX; 3XXX-XXXX; 4XXX-XXXX; 5XXX-XXXX)
4.	O método deve receber uma configuração opcional para indicar qual tipo específico do item acima o chamador quiser. Caso não seja indicado pelo chamador, o método deve escolher aleatoriamente qual deles será gerado e retornado;
5.	O método deve receber uma configuração opcional para indicar qual a UF deve ser usada durante a geração do número, permitindo que apenas os DDDs válidos para cada UF sejam escolhidos. Caso não seja indicado pelo chamador, o método deve escolher aleatoriamente qualquer DDD válido para qualquer lugar do país;
6.	O método deve receber configurações de formatação do número para o usuário final. Isso inclui possibilidades como:
  - Permitir um número sem formatação nenhuma e sem DDD. Exemplo: 47881220
  - Permitir formatações cumulativas, como:
  - Exibir ou não o DDD antes do número. Exemplo: 1147881220
  - Exibir caracteres especiais e espaços entre cada item. Exemplo: 11 4788-1220

<hr/>

<h2>Solução</h2>

Para criar essa solução foi feito um builder que contrói um número com as especificidades declaradas:

<h3>Exemplo de uso do Builder:</h3>

>TelefoneBuilder builder = new();
>
>builder
>  .NumeroFixo() <br/>
>  .ComFormatacao()<br/>
>  .DefineEstadoParaDdd("BA");<br/>
>  
>builder.constroi();<br/>

<h4>Resultado</h4>
> Telefone Gerado: (71) 4356-4537
