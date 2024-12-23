// See https://aka.ms/new-console-template for more information

using System.Net.NetworkInformation;
using Explorando.Models;

Pessoa p1 = new Pessoa(nome: "Lari", sobrenome: "Ruiz");

Pessoa p2 = new Pessoa(nome: "Ana", sobrenome: "Beatriz");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

