using MyMLApp;
using System.Collections.Generic;

// Add multiple input data
var samples = new List<SentimentModel.ModelInput>()
{
    new SentimentModel.ModelInput() { Col0 = "This restaurant was horrible." },
    new SentimentModel.ModelInput() { Col0 = "Wow, great meal!" },
    new SentimentModel.ModelInput() { Col0 = "The service was terrible." },
    // Add more samples here as needed
};

// Load model and predict output for each sample data
foreach (var sample in samples)
{
    var result = SentimentModel.Predict(sample);

    // If Prediction is 1, sentiment is "Positive"; otherwise, sentiment is "Negative"
    var sentiment = result.Prediction == 1 ? "Positive" : "Negative";
    Console.WriteLine($"Text: {sample.Col0}\nSentiment: {sentiment}\n");
}