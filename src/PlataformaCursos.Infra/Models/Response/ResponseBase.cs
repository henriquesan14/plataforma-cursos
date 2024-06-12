namespace PlataformaCursos.Infra.Models.Response
{
    public class ResponseBase<T>
    {
        public bool HasMore { get; set; }
        public int TotalCount { get; set; }
        public int Limit { get; set; }
        public int Offset { get; set; }
        public List<T> Data { get; set; }
    }
}
