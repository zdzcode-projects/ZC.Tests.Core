namespace MainProjectClassLibrary
{
    public class MainService
    {
        private readonly FirstService _firstService;

        public MainService(FirstService firstService)
        {
            _firstService = firstService;
        }

        public bool Sign(string email, string password)
        {
            if(!_firstService.IsValid(email, password))
            {
                throw new Exception("Sign data inválid");
            }

            //ToDo: Sign process...

            return true;
        }
    }
}