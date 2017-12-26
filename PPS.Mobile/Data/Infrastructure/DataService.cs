using System;
using System.Threading.Tasks;
using Firebase.Xamarin.Database;
using PPS.Mobile.Data.Contracts;
using PPS.Mobile.Data.Models;

namespace PPS.Mobile.Data.Infrastructure
{
    public class DataService:IDataService
    {
        private FirebaseClient firebase;
        public DataService()
        {
            firebase = new FirebaseClient("https://pothole-positioning-system.firebaseio.com/");
        }

        public async Task AddIssue(Issue issue)
        {
            await firebase.Child("issues").PostAsync(issue, true);
                          
        }
    }
}
