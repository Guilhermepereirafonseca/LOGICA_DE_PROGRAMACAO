using Aula_11_Herança;

Aluno usuario = new Aluno();
usuario.setNome("Guilherme Pereira Fonseca");
usuario.setIdade(19);
usuario.setSexo("Masculino");
usuario.setCurso("Programador WEB");
usuario.setRegistro(21);

// Exibindo na tela
Console.WriteLine("Nome: " + usuario.getNome());
Console.WriteLine("Idade: " + usuario.getIdade());
Console.WriteLine("Cursando o curso: " + usuario.getCurso());
Console.WriteLine("Número de registro acadêmico: " + usuario.getRegistro());
Console.ReadKey();