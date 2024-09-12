using System;

    namespace WinstonApp
    {
        public class Chapters
        {
            public string title;
            public string description;
            public string[] action;
            public string[] answer;
        }

        public class Chapter1
        {

            public Chapters chapter;
            public Chapter1()
            {
                chapter = new Chapters();
                chapter.title = "Capítulo 1: O Despertar";
                chapter.description = "Winston está em um quarto escuro, com móveis antigos e uma janela trancada. O ar é pesado e cheira a mofo. A única fonte de luz é uma vela apagada sobre uma mesa de cabeceira. As paredes estão cobertas de papel de parede desbotado e rasgado, e há uma sensação de abandono e desespero no ar.";
                chapter.action = new string[] {"1 - Explorar o quarto", "2 - Acender a vela"};
                chapter.answer = new string[] {"Winston se levanta lentamente, sentindo o chão frio sob seus pés descalços. Ele examina a mesa de cabeceira e encontra uma caixa de fósforos ao lado da vela.", "Com mãos trêmulas, Winston risca um fósforo e acende a vela. A luz fraca revela uma mensagem escrita na parede com algo que parece sangue: “Saia enquanto pode.”"};
            }
            
        }

        public class Chapter2
        {
            public Chapters chapter;

            public Chapter2()
            {
                chapter = new Chapters();

                chapter.title = "Capítulo 2: O Corredor";
                chapter.description = "Winston abre a porta do quarto e se depara com um longo corredor escuro, com várias portas em ambos os lados. O corredor é iluminado apenas pela luz fraca da vela que ele segura. As paredes estão cobertas de retratos antigos de pessoas que parecem observá-lo enquanto ele passa. O chão de madeira range sob seus pés, e ele pode ouvir o som distante de passos ecoando.";
                chapter.action = new string[] {"1 - Abrir a primeira porta", "2 - Ler o diário"};
                chapter.answer = new string[] {"Winston escolhe uma porta ao acaso e a abre lentamente. Dentro, ele encontra uma sala empoeirada com uma estante cheia de livros antigos.","Winston pega um dos livros e percebe que é um diário. Ao folheá-lo, ele descobre que a mansão pertenceu a uma família que desapareceu misteriosamente há muitos anos. As últimas páginas do diário estão cheias de anotações frenéticas sobre rituais e entidades sombrias."};
            }

        }

        public class Chapter3
        {
            public Chapters chapter;

            public Chapter3()
            {
                chapter = new Chapters();

                chapter.title = "Capítulo 3: A Biblioteca";
                chapter.description = "Winston entra em uma biblioteca grande e imponente, cheia de livros empoeirados e móveis antigos. As janelas estão cobertas de cortinas pesadas, bloqueando qualquer luz externa. O ar está denso e cheira a papel velho. No centro da sala, há uma mesa com um grande livro aberto, e ao lado dele, um mapa detalhado da mansão.";
                chapter.action = new string[] {"1 - Explorar a biblioteca","2 - Estudar o mapa"};
                chapter.answer = new string[] {"Winston examina o mapa e percebe que há um quarto secreto marcado em um canto da mansão. Ele decide investigar.", "Winston memoriza o caminho para o quarto secreto e se prepara para sair da biblioteca. Antes de ir, ele pega uma lanterna antiga que encontra em uma prateleira."};
            }
        }

        public class Chapter4
        {
            public Chapters chapter;

            public Chapter4()
            {
                chapter = new Chapters();

                chapter.title = "Capítulo 4: O Quarto Secreto";
                chapter.description = "Winston segue o mapa até uma estante de livros na biblioteca. Ele puxa um livro específico, e a estante se move lentamente, revelando uma passagem secreta. Ele entra no quarto secreto, que é pequeno e claustrofóbico, com paredes cobertas de símbolos estranhos e velas apagadas. No centro da sala, há uma mesa com uma chave antiga e um pergaminho.";
                chapter.action = new string[] {"1 - Entrar no quarto", "2 - Pegar a chave"};
                chapter.answer = new string[] {"Winston pega a chave e o pergaminho. Ao desenrolar o pergaminho, ele vê instruções detalhadas para um ritual de proteção.", "Enquanto Winston estuda o pergaminho, ele ouve passos se aproximando do corredor. Ele apaga a vela rapidamente e se esconde na escuridão."};
            }

        }

        public class Chapter5
        {
            public Chapters chapter;

            public Chapter5()
            {
                chapter = new Chapters();
                chapter.title = "Capítulo 5: A Fuga";
                chapter.description = "Winston sai do quarto secreto e volta ao corredor, tentando encontrar uma saída. Ele sente uma presença sombria seguindo-o, e o ar ao seu redor parece ficar mais frio. Ele corre até uma porta trancada no final do corredor e usa a chave que encontrou para abri-la. Dentro, ele encontra uma sala com um grande espelho no centro.";
                chapter.action = new string[] {"1 - Usar a chave", "2 - Entrar na sala"};
                chapter.answer = new string[] {"Winston destranca a porta e entra na sala, fechando a porta rapidamente atrás de si.", "Ele se aproxima do espelho e vê seu reflexo, mas algo está errado. Seu reflexo parece distorcido e há uma figura sombria atrás dele. Ele se vira rapidamente, mas não vê nada. Em pânico, ele quebra o espelho, revelando uma passagem secreta atrás dele."};
            }
        }
        public class Chapter6
         {
            public Chapters chapter; 
            public Chapter6()
            {
                chapter = new Chapters();
                chapter.title = "Capítulo 6: O Espelho";
                chapter.description = "Winston entra na passagem secreta revelada pelo espelho quebrado. A passagem é estreita e escura, com paredes de pedra fria. Ele sente uma corrente de ar gelado e ouve sussurros indistintos ao longe. A luz da vela tremula, lançando sombras dançantes nas paredes.";
                chapter.action = new string[] {"1 - Explorar a passagem", "2 - Seguir os sussurros"};
                chapter.answer = new string[] {"Winston avança cautelosamente pela passagem, sentindo a presença de algo maligno ao seu redor.", "Os sussurros parecem guiá-lo até uma porta de madeira antiga no final da passagem. Ele a abre lentamente e entra em uma nova sala."};
            }
        }
          public class Chapter7
        {
            public Chapters chapter;
            public Chapter7()
            {
                chapter = new Chapters();
                chapter.title = "Capítulo 7: A Passagem";
                chapter.description = "A sala é pequena e claustrofóbica, com paredes cobertas de símbolos estranhos e velas apagadas. No centro da sala, há um altar de pedra com um amuleto antigo e um livro de feitiços. O ar está pesado e cheira a incenso queimado.";
                chapter.action = new string[] {"1 - Examinar o altar", "2 - Ler o livro de feitiços"};
                chapter.answer = new string[] {"Winston se aproxima do altar e pega o amuleto. Ele sente uma onda de energia percorrer seu corpo.", "Winston abre o livro e descobre instruções para um ritual de proteção. Ele decide levar o livro com ele."};
            }
        }

        public class Chapter8
                {
                    public Chapters chapter;

                    public Chapter8()
                    {
                        chapter = new Chapters();
                        chapter.title = "Capítulo 8: O Altar";
                        chapter.description = "Winston sente que está sendo observado enquanto estuda o livro de feitiços. As sombras nas paredes parecem se mover por conta própria, e ele ouve passos suaves ao seu redor. Ele sabe que precisa sair dali rapidamente.";
                        chapter.action = new string[] {"1 - Pegar o amuleto", "2 - Sair da sala"};
                        chapter.answer = new string[] {"Winston coloca o amuleto em volta do pescoço, sentindo-se um pouco mais seguro.", "Ele apaga a vela e sai da sala, voltando para a passagem escura."};
                    }
                }

        public class Chapter9
                {
                    public Chapters chapter;

                    public Chapter9()
                    {
                        chapter = new Chapters();
                        chapter.title = "Capítulo 9: A Presença";
                        chapter.description = "Winston sente que está sendo seguido enquanto caminha pela passagem. O ar ao seu redor fica mais frio, e ele ouve sussurros ameaçadores em uma língua desconhecida. Ele acelera o passo, tentando encontrar uma saída.";
                        chapter.action = new string[] {"1 - Olhar ao redor", "2 - Correr para a saída"};
                        chapter.answer = new string[] {"Winston olha para trás e vê sombras se movendo rapidamente em sua direção.", "Ele corre pelo corredor, sentindo a presença sombria cada vez mais próxima."};
                    }
                }

        public class Chapter10
                {
                    public Chapters chapter;

                    public Chapter10()
                    {
                        chapter = new Chapters();
                        chapter.title = "Capítulo 10: O Jardim";
                        chapter.description = "Winston finalmente encontra uma porta que leva a um jardim abandonado. O jardim está coberto de neblina, e as plantas estão mortas e retorcidas. Ele sente uma sensação de alívio ao respirar o ar fresco, mas sabe que ainda não está seguro.";
                        chapter.action = new string[] {"1 - Explorar o jardim", "2 - Usar a chave"};
                        chapter.answer = new string[] {"Winston caminha pelo jardim, procurando uma saída. Ele encontra uma estufa trancada e decide investigar.", "Ele usa a chave que encontrou anteriormente para abrir a porta da estufa e entra."};
                    }
                }

        public class Chapter11
        {
            public Chapters chapter;
            public Chapter11()
            {
                chapter = new Chapters();
                chapter.title = "Capítulo 11: A Estufa";
                chapter.description = "A estufa está cheia de plantas mortas e vasos quebrados. O ar está úmido e cheira a terra podre. No centro da estufa, há uma mesa com um diário antigo e várias ervas secas espalhadas.";
                chapter.action = new string[] {"1 - Explorar a estufa", "2 - Ler o diário"};
                chapter.answer = new string[] {"Winston examina a mesa e encontra um diário com anotações sobre rituais de magia negra.", "Ele descobre que a família que viveu na mansão praticava rituais sombrios para invocar entidades malignas. As anotações mencionam um ritual específico que pode proteger contra essas entidades."};
            }
        }

        public class Chapter12
        {
            public Chapters chapter;
            public Chapter12()
            {
                chapter = new Chapters();
                chapter.title = "Capítulo 12: O Ritual";
                chapter.description = "Winston percebe que precisa realizar o ritual de proteção para se salvar. Ele reúne as ervas secas e outros ingredientes mencionados no diário. O ar ao seu redor parece ficar mais pesado, e ele sente uma presença maligna se aproximando.";
                chapter.action = new string[] {"1 - Seguir as instruções do diário", "2 - Sentir uma força invisível"};
                chapter.answer = new string[] {"Winston começa a preparar o ritual, misturando os ingredientes e recitando as palavras do feitiço.", "Enquanto ele realiza o ritual, uma força invisível tenta impedi-lo, empurrando-o e sussurrando ameaças em seu ouvido."};
            }
        }

        public class Chapter13
        {
            public Chapters chapter;
            public Chapter13()
            {
                chapter = new Chapters();
                chapter.title = "Capítulo 13: O Cemitério";
                chapter.description = "Winston consegue completar o ritual e sente uma onda de energia protetora ao seu redor. Ele sai da estufa e encontra um caminho que leva a um cemitério antigo e sombrio. As lápides estão cobertas de musgo, e o ar está frio e úmido.";
                chapter.action = new string[] {"1 - Explorar o cemitério", "2 - Ler as lápides"};
                chapter.answer = new string[] {"Winston caminha pelo cemitério, lendo as lápides e descobrindo que muitos membros da família foram enterrados ali.", "Ele encontra uma lápide com seu próprio nome e data de nascimento, mas a data de morte está em branco. Ele sente um calafrio ao perceber que está destinado a morrer ali se não escapar."};
            }
        }

        public class Chapter14
        {
            public Chapters chapter;
            public Chapter14()
            {
                chapter = new Chapters();
                chapter.title = "Capítulo 14: O Mausoléu";
                chapter.description = "No centro do cemitério, Winston encontra um mausoléu imponente. A porta está entreaberta, e ele sente uma atração inexplicável para entrar. O interior do mausoléu é frio e úmido, com paredes de pedra e uma escada que desce para uma cripta.";
                chapter.action = new string[] {"1 - Entrar no mausoléu", "2 - Descer a escada"};
                chapter.answer = new string[] {"Winston desce a escada, ouvindo vozes sussurrando seu nome.", "Ele chega a uma cripta escura, onde encontra um sarcófago aberto. Dentro do sarcófago, há um corpo que se parece exatamente com ele."};
            }
        }

        public class Chapter15
        {
            public Chapters chapter;
            public Chapter15()
            {
                chapter = new Chapters();
                chapter.title = "Capítulo 15: A Cripta";
                chapter.description = "A cripta é fria e úmida, com paredes de pedra cobertas de musgo. O ar está pesado e cheira a decomposição. Winston sente que está perdendo a sanidade ao olhar para o corpo no sarcófago, que parece ser uma versão morta dele mesmo.";
                chapter.action = new string[] {"1 - Explorar a cripta", "2 - Tocar o corpo"};
                chapter.answer = new string[] {"Winston examina o sarcófago e encontra um amuleto idêntico ao que está usando.", "Ao tocar o corpo, ele sente uma dor intensa e uma visão de sua própria morte. Ele recua em pânico e decide sair da cripta."};
            }
        }

        public class Chapter16
        {
            public Chapters chapter;
            public Chapter16()
            {
                chapter = new Chapters();
                chapter.title = "Capítulo 16: O Reflexo";
                chapter.description = "Winston sai da cripta e volta ao cemitério, sentindo que está sendo seguido. Ele olha ao redor e vê sombras se movendo entre as lápides. O ar está frio e ele ouve risadas malignas ao longe.";
                chapter.action = new string[] {"1 - Correr para fora da cripta", "2 - Ouvir risadas malignas"};
                chapter.answer = new string[] {"Winston corre pelo cemitério, tentando encontrar uma saída.", "As risadas parecem vir de todas as direções, e ele sente que está sendo caçado por algo invisível."};
            }
        }

        public class Chapter17
        {
            public Chapters chapter;
            public Chapter17()
            {
                chapter = new Chapters();
                chapter.title = "Capítulo 17: A Floresta";
                chapter.description = "Winston encontra um caminho que leva a uma floresta densa e escura ao redor da mansão. As árvores são altas e retorcidas, bloqueando a luz do sol. O chão está coberto de folhas mortas e galhos quebrados.";
                chapter.action = new string[] {"1 - Explorar a floresta", "2 - Encontrar uma cabana abandonada"};
                chapter.answer = new string[] {"Winston caminha pela floresta, ouvindo sons estranhos e sentindo que está sendo observado.", "Ele encontra uma cabana velha e decide entrar para se abrigar."};
            }
        }

        public class Chapter18
        {
            public Chapters chapter;
            public Chapter18()
            {
                chapter = new Chapters();
                chapter.title = "Capítulo 18: A Proteção";
                chapter.description = "A cabana está em ruínas, com paredes de madeira apodrecida e janelas quebradas. No interior, Winston encontra símbolos de proteção desenhados nas paredes e no chão. Ele sente uma sensação de segurança temporária.";
                chapter.action = new string[] {"1 - Estudar os símbolos", "2 - Criar um amuleto de proteção"};
                chapter.answer = new string[] {"Winston examina os símbolos e percebe que eles podem ser usados para criar um amuleto de proteção.", "Ele reúne materiais da cabana e cria um novo amuleto, sentindo-se um pouco mais seguro."};
            }
        }


        public class Chapter19
        {
            public Chapters chapter;
            public Chapter19()
            {
                chapter = new Chapters();
                chapter.title = "Capítulo 19: O Confronto";
                chapter.description = "Enquanto Winston está na cabana, a figura sombria aparece na porta. A presença maligna é palpável, e ele sente uma onda de medo. A figura começa a se aproximar lentamente.";
                chapter.action = new string[] {"1 - Usar o amuleto de proteção", "2 - Fugir da cabana"};
                chapter.answer = new string[] {"Winston segura o amuleto de proteção e recita as palavras do feitiço. A figura recua, mas não desaparece completamente.", "Winston aproveita a oportunidade para fugir da cabana e voltar para a floresta, sentindo que a figura ainda está seguindo-o."};
            }
        }

        public class Chapter20
        {
            public Chapters chapter;
            public Chapter20()
            {
                chapter = new Chapters();
                chapter.title = "Capítulo 20: A Revelação";
                chapter.description = "Winston corre pela floresta, sentindo a figura sombria se aproximando. Ele tropeça em uma raiz e cai, mas rapidamente se levanta. Ao olhar para trás, ele vê a figura parada à distância, observando-o. De repente, ele percebe que a figura sombria é um membro da família que viveu na mansão.";
                chapter.action = new string[] {"1 - Confrontar a figura", "2 - Prometer quebrar a maldição"};
                chapter.answer = new string[] {"Winston se aproxima cautelosamente da figura e pergunta quem ela é. A figura revela que é um ancestral da família, amaldiçoado por um ritual que deu errado.", "Winston promete ajudar a quebrar a maldição e libertar a alma do ancestral. A figura lhe dá uma pista sobre onde encontrar os ingredientes necessários para o ritual."};
            }
        }

        public class Chapter21
        {
            public Chapters chapter;
            public Chapter21()
            {
                chapter = new Chapters();
                chapter.title = "Capítulo 21: A Busca";
                chapter.description = "Winston retorna à mansão com a nova determinação de quebrar a maldição. Ele usa o mapa que encontrou na biblioteca para procurar pistas sobre os ingredientes necessários para o ritual. A mansão parece ainda mais sombria e ameaçadora do que antes.";
                chapter.action = new string[] {"1 - Explorar a mansão", "2 - Ler o livro"};
                chapter.answer = new string[] {"Winston revisita várias salas da mansão, procurando por pistas e ingredientes. Ele encontra um livro de feitiços na biblioteca que descreve os ingredientes necessários.", "O livro menciona ervas raras, ossos antigos e um artefato mágico que estão espalhados pela mansão e seus arredores."};
            }
        }

        public class Chapter22
        {
            public Chapters chapter;
            public Chapter22()
            {
                chapter = new Chapters();
                chapter.title = "Capítulo 22: Os Ingredientes";
                chapter.description = "Winston começa a procurar os ingredientes mencionados no livro de feitiços. Ele sente a presença maligna se intensificando à medida que se aproxima de cada ingrediente.";
                chapter.action = new string[] {"1 - Encontrar ervas na estufa", "2 - Encontrar ossos no cemitério"};
                chapter.answer = new string[] {"Winston retorna à estufa e encontra as ervas raras mencionadas no livro. Ele sente uma presença maligna se aproximando e apressa-se a sair.", "Winston volta ao cemitério e desenterra ossos antigos de um túmulo marcado com símbolos estranhos. Ele ouve sussurros ameaçadores enquanto trabalha."};
            }
        }

        public class Chapter23
        {
            public Chapters chapter;
            public Chapter23()
            {
                chapter = new Chapters();
                chapter.title = "Capítulo 23: O Feitiço";
                chapter.description = "Winston reúne todos os ingredientes e retorna ao altar na passagem secreta. Ele sente uma energia poderosa ao seu redor enquanto prepara o feitiço.";
                chapter.action = new string[] {"1 - Seguir as instruções do livro", "2 - Recitar o feitiço"};
                chapter.answer = new string[] {" Winston mistura os ingredientes e recita as palavras do feitiço. A sala começa a tremer e ele sente uma força invisível tentando impedi-lo.", "Winston continua recitando o feitiço, sentindo a energia ao seu redor aumentar. Ele vê a figura sombria se aproximando, mas não para."};
            }
        }

        public class Chapter24
        {
            public Chapters chapter;
            public Chapter24()
            {
                chapter = new Chapters();
                chapter.title = "Capítulo 24: A Batalha";
                chapter.description = "A figura sombria tenta impedir que Winston complete o feitiço. A presença maligna é palpável e ele sente uma onda de medo. A figura começa a se aproximar rapidamente.";
                chapter.action = new string[] {"1 - Usar o amuleto de proteção", "2 - Completar o feitiço"};
                chapter.answer = new string[] {"Winston segura o amuleto de proteção e recita as palavras do feitiço. A figura recua, mas não desaparece completamente.", " Winston continua recitando o feitiço, sentindo a energia ao seu redor aumentar. Ele vê a figura sombria se aproximando, mas não para."};
            }
        }

        public class Chapter25
        {
            public Chapters chapter;
            public Chapter25()
            {
                chapter = new Chapters();
                chapter.title = "Capítulo 25: A Libertação";
                chapter.description = "Winston sente que a maldição foi quebrada. A figura sombria desaparece e a sala fica em silêncio. Ele sente uma onda de alívio e percebe que as sombras na mansão começaram a desaparecer.";
                chapter.action = new string[] {"1 - Explorar a mansão", "2 - Encontrar uma saída"};
                chapter.answer = new string[] {"Winston revisita várias salas da mansão, vendo que as sombras desapareceram e a atmosfera está mais leve.", "Ele encontra uma porta que leva ao exterior da mansão e sente uma sensação de alívio ao ver a luz do dia."};
            }
        }

        public class Chapter26
        {
            public Chapters chapter;
            public Chapter26()
            {
                chapter = new Chapters();
                chapter.title = "Capítulo 26: A Saída";
                chapter.description = "Winston encontra a porta de saída da mansão. Ele abre a porta e vê a luz do dia pela primeira vez desde que entrou na mansão. Ele sente uma sensação de liberdade e alívio.";
                chapter.action = new string[] {"1 - Abrir a porta", "2 - Sair da mansão"};
                chapter.answer = new string[] {"Winston abre a porta e sai da mansão, sentindo o sol em seu rosto.", "Ele caminha para fora da mansão, sentindo que finalmente está livre."};
            }
        }

        public class Chapter27
        {
            public Chapters chapter;
            public Chapter27()
            {
                chapter = new Chapters();
                chapter.title = "Capítulo 27: O Alívio";
                chapter.description = "Winston sente-se aliviado por ter escapado da mansão. Ele olha para trás e vê a mansão desmoronando lentamente. Ele sabe que a maldição foi quebrada e que a mansão não representa mais uma ameaça.";
                chapter.action = new string[] {"1 - Olhar para trás", "2 - Caminhar para a liberdade"};
                chapter.answer = new string[] {"Winston olha para trás e vê a mansão desmoronando. Ele sente uma sensação de realização e alívio.", "Ele caminha para longe da mansão, sentindo uma nova esperança e determinação."};
            }
        }

        public class Chapter28
        {
            public Chapters chapter;
            public Chapter28()
            {
                chapter = new Chapters();
                chapter.title = "Capítulo 28: O Retorno";
                chapter.description = "Winston volta para a sua vida normal, mas sabe que nunca será o mesmo. A experiência na mansão o mudou para sempre. Ele reflete sobre o que aconteceu e promete nunca mais voltar àquele lugar.";
                chapter.action = new string[] {"1 - Refletir sobre a experiência", "2 - Prometer nunca mais voltar à mansão"};
                chapter.answer = new string[] {"Winston pensa sobre tudo o que aconteceu e como isso o afetou.", "Ele promete a si mesmo que nunca mais voltará à mansão e que viverá sua vida ao máximo."};
            }
        }

        public class Chapter29
        {
            public Chapters chapter;
            public Chapter29()
            {
                chapter = new Chapters();
                chapter.title = "Capítulo 29: A Assombração";
                chapter.description = "Winston começa a perceber que algo ainda está errado. Ele sente que está sendo observado e ouve sussurros à noite. Ele percebe que a maldição pode não ter sido completamente quebrada.";
                chapter.action = new string[] {"1 - Investigar os sussurros", "2 - Buscar ajuda"};
                chapter.answer = new string[] {"Winston começa a investigar os sussurros e descobre que a presença maligna ainda está com ele.", "Ele decide buscar ajuda para se livrar da presença maligna de uma vez por todas."};
            }
        }

        public class Chapter30
        {
            public Chapters chapter;
            public Chapter30()
            {
                chapter = new Chapters();
                chapter.title = "Capítulo 30: O Exorcismo";
                chapter.description = "Winston encontra um especialista em exorcismos que concorda em ajudá-lo. Eles realizam um ritual final para banir a presença maligna de sua vida.";
                chapter.action = new string[] {"1 - Realizar o exorcismo", "2 - Banir a presença maligna"};
                chapter.answer = new string[] {"Winston e o especialista realizam o ritual, enfrentando a presença maligna uma última vez. A sala fica cheia de uma luz intensa e a presença maligna parece ser banida.", "Com o ritual completo, a presença maligna é finalmente banida e Winston sente uma paz verdadeira pela primeira vez."};
            }
        }          
    }