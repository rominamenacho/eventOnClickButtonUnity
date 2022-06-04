public class UseCase
{
    Domain domain;
    public UseCase()
    {
        domain = new Domain();
    }

    public int getScore()
    {
        return domain.Score;
    }

    public void IncreaseScore()
    {
        domain.Score += 1;
    }
}
