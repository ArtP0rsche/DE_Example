using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Store21WebApplication.Models;

public partial class Product
{
    public int Id { get; set; }

    [Display(Name = "Артикул")]
    public string Article { get; set; } = null!;

    [Display(Name = "Наименование товара")]
    public string Title { get; set; } = null!;

    [Display(Name = "Единица измерения")]
    public string Unit { get; set; } = null!;

    [Display(Name = "Цена")]
    public decimal Price { get; set; }

    [Display(Name = "Поставщик")]
    public int ProviderId { get; set; }

    [Display(Name = "Производитель")]
    public int ManufacturerId { get; set; }

    [Display(Name = "Категория товара")]
    public string Category { get; set; } = null!;

    [Display(Name = "Действующая скидка")]
    public int Discount { get; set; }

    [Display(Name = "Количество на складе")]
    public int Amount { get; set; }

    [Display(Name = "Описание товара")]
    public string Description { get; set; } = null!;

    [Display(Name = "Фото")]
    public string? Photo { get; set; }

    [Display(Name = "Производитель")]
    public virtual Manufacturer Manufacturer { get; set; } = null!;

    [Display(Name = "Поставщик")]
    public virtual Provider Provider { get; set; } = null!;
}
