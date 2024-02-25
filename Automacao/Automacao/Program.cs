using Automacao;
using java.util;

WhatsappMsg zap = new WhatsappMsg();

string destino = "Destinatario";
string texto = @"Nada vai dar certo,- 
não importa os sonhos e esperanças que tinham..- 
nao importa o quanto a vida de vocês é abençoada...-
será tudo igual quando forem esmagados por rochas. -
Todos morrerão um dia.-
Quer dizer que a vida não tem sentido?-
Teve algum sentido em termos nascido?- 
O que vocês diriam dos nossos companheiros que morreram?- 
As vidas deles... não tinham sentido?- 
Não, tinham!- 
Somos nós que damos significado ás vidas dos nossos companheiros!- 
Aqueles corajosos caídos!- 
AFLITOS caídos!- 
Aqueles que se lembrarão deles somos nós... os vivos!- 
Morreremos aqui, e deixamos para os que ficarem encontrar significado nas nossas vidas!- 
Esse é o único método que temos para nós rebelar contra esse mundo Cruel!- 
Soldados, fúria!- 
Soldados, gritem!- 
SOLDADOS LUTEM!";

string fala;
int indexTraco;
for (int i = 0; i < texto.Length; i++)
{
    indexTraco = texto.IndexOf('-');
    fala = texto.Substring(0, indexTraco++);

    Thread.Sleep(2000);
    zap.SendMessage(fala, destino);

    texto = texto.Substring(indexTraco);
}



