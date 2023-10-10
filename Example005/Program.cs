Console.WriteLine("Представьтесь пожалуйста!");
string nameuser = Console.ReadLine();
if(nameuser.ToLower() == "маша"){
    Console.WriteLine("Привет, самый прекрасный человек на свете!");
} else {
    Console.WriteLine("Здравствуйте, " + nameuser);
}