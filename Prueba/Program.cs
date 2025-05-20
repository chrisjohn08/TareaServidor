namespace Tests {


    public class Program {


        static void Main(string[] args) {

                SshServiceTests service = new SshServiceTests();
                service.ExecuteCommand_Valid_CallsConnectExecuteDisconnect();

        }

    }
}
