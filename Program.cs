using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string inputText = " 1 июля 2015 года Греция объявила о дефолте по государственному долгу, став первой развитой страной в истории, которая не смогла выплатить свои долговые обязательства в полном объеме. Сумма дефолта составила порядка 1,6 миллиарда евро. Этому предшествовали долгие переговоры с международными кредиторами, такими как Международный валютный фонд (МВФ), Европейский центральный банк (ЕЦБ) и Европейская комиссия (ЕК), о программах финансовой помощи и реструктуризации долга. Основными причинами дефолта стали недостаточная эффективность реформ, направленных на улучшение финансовой стабильности страны, а также политическая нестабильность, что вызвало потерю доверия со стороны международных инвесторов и кредиторов. Последствия дефолта оказались глубокими и долгосрочными: сокращение кредитного рейтинга страны, увеличение затрат на заемный капитал, рост стоимости заимствований и утрата доверия со стороны международных инвесторов. х угодий и незаконная добыча древесины. Это приводит к серьезным экологическим последствиям, таким как потеря биоразнообразия, ухудшение к";
            //string inputText = "William Shakespeare, widely regarded as one of the greatest writers in the English language, authored a total of 37 plays, along with numerous poems and sonnets. He was born in Stratford-upon-Avon, England, in 1564, and died in 1616. Shakespeare's most famous works, including \"Romeo and Juliet,\" \"Hamlet,\" \"Macbeth,\" and \"Othello,\" were written during the late 16th and early 17th centuries. \"Romeo and Juliet,\" a tragic tale of young love, was penned around 1595. \"Hamlet,\" one of his most celebrated tragedies, was written in the early 1600s, followed by \"Macbeth,\" a gripping drama exploring themes of ambition and power, around 1606. \"Othello,\" a tragedy revolving around jealousy and deceit, was also composed during this period, believed to be around 1603.";
            //string inputText = "После многолетних исследований ученые обнаружили\r\nтревожную тенденцию в вырубке лесов Амазонии.\r\nАнализ данных показал, что основной участник\r\nразрушения лесного покрова – человеческая\r\nдеятельность. За последние десятилетия рост объема\r\nвырубки достиг критических показателей. Главными\r\nфакторами, способствующими этому, являются\r\nпромышленные рубки, производство древесины,\r\nрасширение сельскохозяйственных угодий и\r\nнезаконная добыча древесины. Это приводит к\r\nсерьезным экологическим последствиям, таким как\r\nпотеря биоразнообразия, ухудшение климата и угроза\r\nвымирания многих видов животных и растений.";
            string inputText = "После многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазонии. Анализ данных показал, что основной участник разрушения лесного покрова – человеческая деятельность. За последние десятилетия рост объема вырубки достиг критических показателей. Главными факторами, способствующими этому, являются промышленные рубки, производство древесины, расширение сельскохозяйственных угодий и незаконная добыча древесины. Это приводит к серьезным экологическим последствиям, таким как потеря биоразнообразия, ухудшение климата и угроза вымирания многих видов животных и растений.";
            //string inputText = "William Shakespeare, widely regarded as one of the greatest writers in the English language, authored a total of 37 plays, along with numerous poems and sonnets. He was born in Stratford-upon-Avon, England, in 1564, and died in 1616. Shakespeare's most famous works, including \"Romeo and Juliet,\" \"Hamlet,\" \"Macbeth,\" and \"Othello,\" were written during the late 16th and early 17th centuries. \"Romeo and Juliet,\" a tragic tale of young love, was penned around 1595. \"Hamlet,\" one of his most celebrated tragedies, was written in the early 1600s, followed by \"Macbeth,\" a gripping drama exploring themes of ambition and power, around 1606. \"Othello,\" a tragedy revolving around jealousy and deceit, was also composed during this period, believed to be around 1603.";

            //Console.WriteLine(inputText.Replace(" ", "  "));
            int s = 0;
            //string d = "После многолетних исследований ученые обнаружили\r\nтревожную тенденцию в вырубке лесов Амазонии.\r\nАнализ данных показал, что основной участник\r\nразрушения лесного покрова – человеческая\r\nдеятельность. За последние десятилетия рост объема\r\nвырубки достиг критических показателей. Главными\r\nфакторами, способствующими этому, являются\r\nпромышленные рубки, производство древесины,\r\nрасширение сельскохозяйственных угодий и\r\nнезаконная добыча древесины. Это приводит к\r\nсерьезным экологическим последствиям, таким как\r\nпотеря биоразнообразия, ухудшение климата и угроза\r\nвымирания многих видов животных и растений.";
            //string inputText = "Фьорды – это ущелья, формирующиеся ледниками и заполняющиеся морской водой. Название происходит от древнескандинавского слова \"fjǫrðr\". Эти глубокие заливы, окруженные высокими горами, представляют захватывающие виды и природную красоту. Они популярны среди туристов и известны под разными названиями: в Норвегии – \"фьорды\", в Шотландии – \"фьордс\", в Исландии – \"фьордар\". Фьорды играют важную роль в культуре и туризме региона, продолжая вдохновлять людей со всего мира.";
            //string d = "– это ущелья, формирующиеся ледниками и заполняющиеся морской водой. Название происходит от древнескандинавского слова \"fjǫrðr\". Эти глубокие заливы, окруженные высокими горами, представляют захватывающие виды и природную красоту. Они популярны среди туристов и известны под разными названиями: в Норвегии – \"\", в Шотландии – \"\", в Исландии – \"\". играют важную роль в культуре и туризме региона, продолжая вдохновлять людей со всего мира.";
            Blue_3 processor = new Blue_3(inputText);
            //string d = "многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазонии. Анализ данных показал, что участник разрушения лесного покрова – человеческая. За десятилетия объема вырубки критических показателей. Главными факторами, этому, являются промышленные рубки, производство древесины, расширение сельскохозяйственных угодий и незаконная добыча древесины. Это приводит к серьезным экологическим, таким как потеря биоразнообразия, ухудшение климата и угроза вымирания многих видов животных и растений.";
           // string d = "Shakespeare, widely regarded as one of the greatest writers in the English language, authored a total of 37 plays, along with numerous poems and sonnets. He was born in Stratford-upon-Avon, England, in 1564, and died in 1616. Shakespeare's most famous works, including \"Romeo and Juliet,\" \"Hamlet,\" \"Macbeth,\" and \"Othello,\" were written during the late 16th and early 17th centuries. \"Romeo and Juliet,\" a tragic tale of young love, was penned around 1595. \"Hamlet,\" one of his most celebrated tragedies, was written in the early 1600s, followed by \"Macbeth,\" a gripping drama exploring themes of ambition and power, around 1606. \"Othello,\" a tragedy revolving around jealousy and deceit, was also composed during this period, believed to be around 1603.";
            processor.Review();
            string f = "п - 14,9254\r\nд - 10,4478\r\nв - 7,4627\r\nр - 7,4627\r\nу - 7,4627\r\nи - 5,9701\r\nк - 5,9701\r\nо - 4,4776\r\nс - 4,4776\r\nт - 4,4776\r\nэ - 4,4776\r\nа - 2,9851\r\nл - 2,9851\r\nм - 2,9851\r\nч - 2,9851\r\nб - 1,4925\r\nг - 1,4925\r\nж - 1,4925\r\nз - 1,4925\r\nн - 1,4925\r\nф - 1,4925\r\nя - 1,4925";
            Console.WriteLine(processor.ToString());
            foreach (char c in processor.ToString())
            {
                s++;
            }
            Console.WriteLine(s);
            int s2 = 0;
            foreach (char c in f)
            {
                s2++;
            }
            Console.WriteLine(s2);
            Console.WriteLine(f);
            //Console.WriteLine(!char.IsLetter("");
            //string[] text = inputText.Split(' ');
            //foreach(string c in text) { Console.WriteLine(c) ; }
        }
    }
}
