using System;
using com.freeclimb.api;
using com.freeclimb.api.queue;

namespace GetQueue {
  class Program {

    static string getFreeClimbAccountId () { return System.Environment.GetEnvironmentVariable("ACCOUNT_ID"); }
    static string getFreeClimbAccountToken () {return System.Environment.GetEnvironmentVariable("AUTH_TOKEN"); }
    static void Main (string[] args) {
      string queueId = "";
      // Create FreeClimbClient object
      FreeClimbClient client = new FreeClimbClient (getFreeClimbAccountId (),
        getFreeClimbAccountToken ());

      // Invoke get method to retrieve queued metadata
      Queue queue = client.getQueuesRequester.get (queueId);
      Console.WriteLine(queue.getQueueId);
    }
  }
}