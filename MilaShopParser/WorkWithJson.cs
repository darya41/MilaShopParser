using Newtonsoft.Json;

namespace ParseMila
{
    internal class WorkWithJson
    {
        public static void Write(List<Product> products, string link = "data.json")
        {
            try
            {
                string json = JsonConvert.SerializeObject(products, Formatting.Indented);

                File.WriteAllText(link, json);
            }
            catch (IOException e)
            {
                MessageBox.Show($"При открытии файла произошла ошибка ввода-вывода:{e.GetType().Name}");
            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show($"Ссылка указывает на файл, доступный только для чтения: {e.GetType().Name}");
            }
            catch (ArgumentException e)
            {
                MessageBox.Show($" Один из передаваемых методу аргументов является недопустимым:{e.Message}");
            }
            catch (JsonSerializationException e) 
            {
                MessageBox.Show($" Oшибка во время сериализации JSON-файла:{ e.Message}");
            }
            catch(NullReferenceException e)
            {
                MessageBox.Show($" Oшибка получения доступа к члену типа со значением null:{e.Message}");
            }
            catch(Exception e)
            {
                 MessageBox.Show($" Произошла не придвиденная ошибка:{e.Message}");
            }
        }

    }
}
