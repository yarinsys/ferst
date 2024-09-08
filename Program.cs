
static string[] GetQuestions(int countQuestions)
{
string[] questions = new string[5];
questions[0] = "Сколько будет два плюс два умноженное на два?";
questions[1] = "Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?";
questions[2] = "На двух руках 10 пальцев. Сколько пальцев на 5 руках?";
questions[3] = "Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?";
questions[4] = "Пять свечей горело, две потухли. Сколько свечей осталось?";
return questions;
}
int countQuestions = 5; // в случае изменения к-ва вопросов - меняем цифру
string[] questions = GetQuestions(countQuestions); // массив вопросов 

static int[] CheckAnswers(int countAnswers)
{
    int[] answers = new int[5];
    answers[0] = 6;
    answers[1] = 9;
    answers[2] = 25;
    answers[3] = 60;
    answers[4] = 2;
    return answers;
}
int countAnswers = 5; //в случае изменения количество ответов
int[] answers = CheckAnswers(countAnswers);
Console.Write("участник, представьтесь ");
string nameUser = Console.ReadLine();

int countRightAnswers = 0; // счетчик правильных ответов

List<string> lst = new List<string>();
Random random = new Random();

string[] stringQuestions = new string[5]; // здесь будут храниться 5 случаные неповторяющиеся строки из вопросов
int randomQuestionIndex;
for (int i = 0; i < countQuestions; i++)
{
    while (true)
    {
        randomQuestionIndex = random.Next(countQuestions);
        if (!lst.Any(x => x.Equals(questions[randomQuestionIndex]))) // не понятно что за "x" ???? (если это значение ложно, он не записывается в лист)
        {
            lst.Add(questions[randomQuestionIndex]); // добавили в список
            stringQuestions[i] = questions[randomQuestionIndex]; // 
            break;
        }
    }
    Console.WriteLine("вопрос номер " + (i + 1)); // +1 тк с нуля массив
    Console.WriteLine(stringQuestions[i]);

    int rightAnswers = answers[randomQuestionIndex];
    int rightAnswerUser = Convert.ToInt32(Console.ReadLine());
    if (rightAnswerUser == rightAnswers)
    {
        countRightAnswers++;
    }
}
Console.WriteLine("количество правильных ответов пользователя " + nameUser + " = " + MakeDiagnosis(countRightAnswers));

static int MakeDiagnosis (int x)// функция для диагноза
{
    switch (x)
    {
        case 0: Console.WriteLine("Ваш диагноз - идиот"); break;
        case 1: Console.WriteLine("Ваш диагноз - кретин"); break;
        case 2: Console.WriteLine("Ваш диагноз - дурак"); break;
        case 3: Console.WriteLine("Ваш диагноз - нормальный"); break;
        case 4: Console.WriteLine("Ваш диагноз - талант"); break;
        case 5: Console.WriteLine("Ваш диагноз - гений!!!"); break;
    }
    return x;
}