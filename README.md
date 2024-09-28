# GeometryLibrary

`GeometryLibrary` – это библиотека для работы с геометрическими фигурами. На данный момент она поддерживает вычисление площади круга и треугольника по заданным параметрам. Также предоставляет возможность проверки треугольника на прямоугольность.

## Возможности

- Вычисление площади круга по радиусу.
- Вычисление площади треугольника по трем сторонам (с использованием формулы Герона).
- Проверка, является ли треугольник прямоугольным.
- Обработка ошибок и граничных значений при создании объектов.

## Установка

Для использования этой библиотеки склонируйте репозиторий и добавьте проект как зависимость в ваше решение.

```bash
git clone https://github.com/AnApetav/GeometryLibrary.git
```

Затем добавьте ссылку на проект в ваше решение:

```bash
dotnet add [YourProject] reference GeometryLibrary/GeometryLibrary.csproj
```

## Демонстрация работы

Проект `GeometryLibrary.Demo` предоставляет примеры использования библиотеки. Для запуска демо-приложения выполните команду:

```bash
dotnet run --project GeometryLibrary.Demo
```

### Пример: Добавление новой фигуры (Rectangle)
```csharp
public class Rectangle : IShape
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
    {
        if (width <= 0 || height <= 0)
            throw new ArgumentException("The sides of the rectangle must be positive numbers.");

        Width = width;
        Height = height;
    }

    public double CalculateArea()
    {
        return Width * Height;
    }

    public override string ToString()
    {
        return $"Rectangle: Width = {Width}, Height = {Height}";
    }
}
```

## Задание 2:
Запрос к базе данных для выбора пар «Имя продукта – Имя категории». Для реализации связи "многие ко многим" между продуктами и категориями, используем третью связующую таблицу, которая будет содержать внешние ключи к обеим таблицам.

```sql
SELECT
    Products.ProductName,
    Categories.CategoryName
FROM
    Products
LEFT JOIN
    ProductCategories ON Products.ProductID = ProductCategories.ProductID
LEFT JOIN
    Categories ON ProductCategories.CategoryID = Categories.CategoryID;
```
