## Створимо бібліотеку класів:
![image](https://github.com/yura-kiv/crossplatform-uni/assets/94392546/b67a784c-80b4-457c-b2e4-9f7700517543)
![image](https://github.com/yura-kiv/crossplatform-uni/assets/94392546/d09cf23b-cda2-4da7-a4d5-87576112da10)

## Налаштуємо .csproj перед білдом:
![image](https://github.com/yura-kiv/crossplatform-uni/assets/94392546/698666b5-8723-4ec5-a10b-e08cfab16bb8)

## Збілдимо наш проект:
В деректорії нашого преокту знайдемо готовий пакет:
![image](https://github.com/yura-kiv/crossplatform-uni/assets/94392546/06c2c749-a113-4a70-a110-7769b7a01fb8)

## Перейдемо до використання пакету:
1) Створимо консольний застосунок:
![image](https://github.com/yura-kiv/crossplatform-uni/assets/94392546/1c064984-abc3-404a-8610-bbd4d2cb0575)
2) За допомогою менеджера пакетів оберемо шлях до локального розташування:
![image](https://github.com/yura-kiv/crossplatform-uni/assets/94392546/3165ac83-4dad-4ac9-aa73-8bca42d5301c)
3) Інсталюємо його:
![image](https://github.com/yura-kiv/crossplatform-uni/assets/94392546/435e4124-2a50-4181-8f71-2ba0edf97730)
4) Використаємо його за допомогою using:
Код Program.cs:
```csharp
using Lab3CL;

namespace Lab3Usage
{
    class Program
    {
        static void Main(string[] args)
        {

            string pathToInputFile = "../../../input.txt";

            string pathToOutputFile = "../../../output.txt";

            Lab3.Run(pathToInputFile, pathToOutputFile);
        }
    }
}
```
