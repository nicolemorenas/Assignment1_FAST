using System;
using System.Collections.Generic;

namespace Assignment1_FAST.Models
{
	public static class Repository
	{

        private static List<RequestResponse> requests = new List<RequestResponse>();

        public static IEnumerable<RequestResponse> Requests => requests;
		
		public static void AddRequest(RequestResponse request)
        {
            
            requests.Add(request);
        }
	}
}
