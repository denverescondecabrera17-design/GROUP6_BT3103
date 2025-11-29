using CODEINN.Model;
using CODEINN.Repository;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace CODEINN.Controller
{
    public class HistoryController
    {
        private readonly HistoryRepository _historyRepository;

        public HistoryController()
        {
            _historyRepository = new HistoryRepository(); // Initialize the repository
        }

        // Method to add history with transaction support
        public void AddToHistory(History history, SqlTransaction transaction)
        {
            try
            {
                _historyRepository.AddToHistory(history, transaction); // Call the repository method with transaction
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding history: " + ex.Message);
            }
        }
    }
}
