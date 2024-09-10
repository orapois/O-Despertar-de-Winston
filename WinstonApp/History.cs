    using System;
    using System.Threading;
    using System.Threading.Tasks;

    namespace WinstonApp
    {
        public class Chapters
        {
            public string title;
            public string description;
            public string[] action;
            public string[] answer;

            public void Counter(string txt, int interval)
            {
                foreach (var a in txt)
                {
                    Console.Write(a);
                    Thread.Sleep(interval);
                }
                Console.WriteLine();
            }

        }

        public class Chapter1
        {

            private Chapters chapter;
            public Chapter1()
            {
                chapter = new Chapters();
                chapter.title = "Capítulo 1: O Despertar";
                chapter.description = "Winston está em um quarto escuro, com móveis antigos e uma janela trancada. O ar é pesado e cheira a mofo. A única fonte de luz é uma vela apagada sobre uma mesa de cabeceira. As paredes estão cobertas de papel de parede desbotado e rasgado, e há uma sensação de abandono e desespero no ar.";
                chapter.action = new string[] {"1 - Explorar o quarto", "2 - Acender a vela"};
                chapter.answer = new string[] {"Winston se levanta lentamente, sentindo o chão frio sob seus pés descalços. Ele examina a mesa de cabeceira e encontra uma caixa de fósforos ao lado da vela.", "Com mãos trêmulas, Winston risca um fósforo e acende a vela. A luz fraca revela uma mensagem escrita na parede com algo que parece sangue: “Saia enquanto pode.”"};
            }
            
            public void DisplayChapter()
            {

                
                
                  
                chapter.Counter(chapter.title, 200); 
                chapter.Counter(chapter.description, 60);
                foreach (var act in chapter.action)
                {
                    Console.WriteLine(act);
                }
                string a;
                a = Console.ReadLine();
                int ans = Convert.ToInt32(a);
                ans--;
                chapter.Counter(chapter.answer[ans], 60);
            }
            
        }

        public class Chapter2
        {
            private Chapters chapter;

            public Chapter2()
            {
                chapter = new Chapters();

                chapter.title = "Capítulo 2: O Corredor";
                chapter.description = "Winston abre a porta do quarto e se depara com um longo corredor escuro, com várias portas em ambos os lados. O corredor é iluminado apenas pela luz fraca da vela que ele segura. As paredes estão cobertas de retratos antigos de pessoas que parecem observá-lo enquanto ele passa. O chão de madeira range sob seus pés, e ele pode ouvir o som distante de passos ecoando.";
                chapter.action = new string[] {"1 - Abrir a primeira porta", "2 - Ler o diário"};
                chapter.answer = new string[] {"Winston escolhe uma porta ao acaso e a abre lentamente. Dentro, ele encontra uma sala empoeirada com uma estante cheia de livros antigos.","Winston pega um dos livros e percebe que é um diário. Ao folheá-lo, ele descobre que a mansão pertenceu a uma família que desapareceu misteriosamente há muitos anos. As últimas páginas do diário estão cheias de anotações frenéticas sobre rituais e entidades sombrias."};
            }

            public void DisplayChapter()
            {
                chapter.Counter(chapter.title, 100);
                chapter.Counter(chapter.description, 60);
                foreach (var act in chapter.action)
                {
                    chapter.Counter(act, 100);
                }
                string a;
                a = Console.ReadLine();
                int ans = Convert.ToInt32(a);
                ans--;
                chapter.Counter(chapter.answer[ans], 60);
            }
        }
    }