class ageVerification{
    static void Main(){
        Console.WriteLine("Me informe sua Idade :");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age <= 0){
            Console.WriteLine("Por favor informe um Número válido !!");
        }else if(age < 18){
            Console.WriteLine("Você é de Menor");
        }else{
            Console.WriteLine("Você é de Maior");
        }
    }
}
