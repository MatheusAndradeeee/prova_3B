//tava facil facil, mas eu nao pratico nd de programação, ai da ruim mesmo

using Prova_3B;
List<Medico>medicos= new List<Medico>();
List < Administrativo > adm= new List<Administrativo>();
while (true)
{
    Console.WriteLine("Escolha o Funcionario:\n 1 - Médico \n 2 - Administrativo");
    int dig = Convert.ToInt32(Console.ReadLine());
    switch (dig)
    {
        case 1:
            Console.WriteLine("nome");
            string nome = Console.ReadLine();
            Console.WriteLine("cpf");
            string cpf= Console.ReadLine();
            Console.WriteLine("matricula");
            int mat= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("data");
            string data= Console.ReadLine();
            Console.WriteLine("sexo");
            string sexo= Console.ReadLine();
            Console.WriteLine("salario");
            double sala = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("crm");
            string cr= Console.ReadLine();
            Console.WriteLine("hora extra");
            double hr= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("especialização");
            string espe = Console.ReadLine();
           
            Medico a = new Medico(nome,cpf,mat, data, sexo,sala,cr,hr,espe);
             medicos.Add(a);
           
            foreach(Medico medico in medicos)
            {
                Console.WriteLine(medico.Nome);
            }

            break;
           

        case 2:
            Console.WriteLine("nome");
            string nome1 = Console.ReadLine();
            Console.WriteLine("cpf");
            string cpf1 = Console.ReadLine();
            Console.WriteLine("matricula");
            int mat1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("data");
            string data1 = Console.ReadLine();
            Console.WriteLine("sexo");
            string sexo1 = Console.ReadLine();
            Console.WriteLine("salario");
            double sala1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("crm");
            string funcao = Console.ReadLine();
            Administrativo b = new Administrativo(nome1, cpf1, mat1, data1, sexo1, sala1, funcao);
            break;
    }
    



}