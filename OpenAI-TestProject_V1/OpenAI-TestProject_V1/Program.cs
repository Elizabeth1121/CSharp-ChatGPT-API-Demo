using OpenAI_API;
using OpenAI_API.Completions;
using OpenAI_API.Models;

// user asks a question
var question = Console.ReadLine();

// you're api key given to you
var openAI = new OpenAIAPI("API Key Here");
CompletionRequest completionRequest = new CompletionRequest();

// calling on the completionrequest prompt here... the prompt is if your requesting a single prompt only
completionRequest.Prompt = question;

// getting the chat gpt - 3 model here
completionRequest.Model = Model.DavinciText;

// asking the API to complete the full request 
var completions = openAI.Completions.CreateCompletionAsync(completionRequest);

// printing out the anwser to the request
foreach (var completion in completions.Result.Completions)
{
    Console.WriteLine(completion.Text);
}

Console.ReadLine();