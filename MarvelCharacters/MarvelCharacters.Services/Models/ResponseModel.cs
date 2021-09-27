using System.Collections.Generic;

namespace MarvelCharacters.Services.Models
{
    public class ResponseModel<T>
    {
        public bool Status { get; set; }
        public IEnumerable<T> Data { get; set; }

        public void Success(IEnumerable<T> dynamicData)
        {
            Status = true;
            Data = dynamicData;
        }

        public void Fail()
        {
            Status = false;
            Data = null;
        }
    }
}
