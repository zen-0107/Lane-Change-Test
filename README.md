# Lane-Change-Test
É uma versao do lane change test feito em Unity que permite uma melhor portabilidade e facilidade de configurar permitindo ter algumas configuraçoes caso necessario, este segue os standars propostos pelo Lane Change Test ja criado 
Este projeto tem por base o LCT que é um teste de conduçao que serve para medir e comparar o percurso que o piloto fez e o percurso perfeito, neste o piloto tem de seguir as instroçoes dadas pelos sinais que aparecem 
em ambos os lados da estrada, este programa serviu para que nao houvesse a necessidade de fazer testes com veiculos reais assim evitando acidentes e os custos de reparaçao dos veiculos.

Nos testes sao usados as teclas W,A,S e D ou cima, baixo, esquerda e direita para conduzir o veiculo e o espaço para travar e nestes, se nada for modificado antes do teste, contem 18 sianis a distancias semelhantes 
uns dos outros e que quando o carro se aproximar osuficiente dos sinais, aparecem os paineis que indicam a direçao que o condutor deve ir. Qunando o condutor chegar ao fim da pista é escrito os dados numa folha excel 
e se for necessario repetir o teste entao o condutor volta ao inicio para o fazer xaso contraro este volta ao menu principal. 
Cada teste é gerado de forma aletoria e no local ou seja cada sinal ve a posiçao do condutor e escolhe ,com base num numero aleatorio e num numero que diz quantas transiçoes é que ainda podem ser feitas, qual o caminho 
que o condutor tem de ir.
As posiçoes de X e de Z do condutor sao recolhodos a cada 0.5 segundos junto com os dados das posiçoes onde este devia de estar e depois de chegar ao fim sao colocadas numa folha excel para criar um grafico que mostra 
percurso feito por este.
Alem deste projeto seguir os padroes impostos pelo LCT tambem contem um menu de opçoes que permite mudar algumas partes do teste tais como a velocidade , a distancia entre os sinais, a distancia a que estes aparecem 
para o condutor e o comprimento da pista.

O objetivo na criaçao deste projeto é a criaçao de testes padronizados com base no LCT mas numa versao mais recente assim melhorando em varios aspetos tais como portabilidade,a simplicidade de instalaçao e a recolher 
informaçoes. Este foi criado no unity pois é uma ferramenta de criaçao de jogos bastante conhecida pela sua portabilidade e facilidade de instalação e para recolher os dados é usado uma folha de dados Excel tornando 
mais facil a comparaçao dos dados.

O setup necessario é um computador que suporte o unity para que consiga correr o programa

O programa é composto por varias partes sendo elas o Main menu que prmite sair, mudar as opçoes ou começar o test depois é o formulario que pede o id e o numero de repetiçoes para depois ser redirecionado para o teste. 

[https://github.com/TiagoNoite/Lane-Change-Test/blob/main/teste%20condu%C3%A7ao.png](https://github.com/TiagoNoite/Lane-Change-Test/blob/main/teste%20condu%C3%A7ao.png?raw=true)https://github.com/TiagoNoite/Lane-Change-Test/blob/main/teste%20condu%C3%A7ao.png?raw=true

