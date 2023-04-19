using System;
using System.Net.Http;
using Newtonsoft.Json;

public class Program
{
    private static readonly HttpClient _httpClient = new HttpClient();

    static void Main(string[] args)
    {
        // Задайте значения для access token и Instagram User ID
        var accessToken = "MotoNika16";
        var instagramUserId = "brizzet_it";

        // Получение списка подписок
        var response = _httpClient.GetAsync($"https://graph.instagram.com/{instagramUserId}/subscriptions?access_token={accessToken}").Result;
        var responseString = response.Content.ReadAsStringAsync().Result;
        var subscriptions = JsonConvert.DeserializeObject<SubscriptionsResponse>(responseString);

        // Отписка от пользователей
        foreach (var subscription in subscriptions.data)
        {
            var unsubscribeResponse = _httpClient.DeleteAsync($"https://graph.instagram.com/{subscription.id}?access_token={accessToken}").Result;
            var unsubscribeResponseString = unsubscribeResponse.Content.ReadAsStringAsync().Result;

            if (unsubscribeResponse.IsSuccessStatusCode)
            {
                Console.WriteLine($"Успешно отписан от {subscription.username}");
            }
            else
            {
                Console.WriteLine($"Не удалось отписаться от {subscription.username}. Код ошибки: {unsubscribeResponse.StatusCode}");
            }
        }
    }
}

public class SubscriptionsResponse
{
    public Subscription[] data { get; set; }
}

public class Subscription
{
    public string id { get; set; }
    public string username { get; set; }
}