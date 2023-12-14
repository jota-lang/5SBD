namespace EscolaAPI.Models
{
    public class Turma
    {
        public int IDturma { get; set; }
        public int IDdisciplina { get; set; }
        public int IDprofessor { get; set; }
        public string Turma1 { get; set; }

        public Disciplina Disciplina { get; set; }
        public Professor Professor { get; set; }
    }
}
