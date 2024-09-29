using System;
using System.Collections.Generic;

namespace Assignment1_FAST.Models
{
	public static class Repository
	{

        private static List<RequestResponse> requests = new List<RequestResponse>();
        private static int nextId = 1;

        public static IEnumerable<RequestResponse> Requests => requests;
		
		public static void AddRequest(RequestResponse request)
        {
            request.Id = nextId++;
            requests.Add(request);
        }
	}
}
