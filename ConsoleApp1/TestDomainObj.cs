namespace programMain;
internal class TestDomainObj : IReturnToString
{
     public int userId;
     public int Id { get; }
     public string title;
     public string body;

     public TestDomainObj(int userId, int id, string title, string body)
     {
          this.userId = userId;
          this.Id = id;
          this.title = title;
          this.body = body;
     }
     public override string ToString() => $"Id:{Id} Country:{body}";
}
