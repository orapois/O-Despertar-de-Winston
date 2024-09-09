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
                Console.WriteLine(chapter.title);
                Console.WriteLine(chapter.description);
                foreach (var act in chapter.action)
                {
                    Console.WriteLine(act);
                }
                string a;
                a = Console.ReadLine();
                int ans = Convert.ToInt32(a);
                ans--;
                Console.WriteLine(chapter.answer[ans]);
            }
            
        }
    }