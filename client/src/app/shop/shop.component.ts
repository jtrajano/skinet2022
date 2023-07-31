import { Component, OnInit } from '@angular/core';
import { Product } from '../shared/models/product';
import { ShopService } from './shop.service';
import { Brand } from '../module/brand';
import { Type } from '../module/type';

@Component({
  selector: 'app-shop',
  templateUrl: './shop.component.html',
  styleUrls: ['./shop.component.scss']
})

export class ShopComponent implements OnInit{
  products: Product[] = [];
  brands: Brand[] = [];
  types: Type[] = [];

  constructor(private shopService: ShopService)
  {
    
  }
  ngOnInit(): void {
    this.getProducts();
    this.getBrands();
    this.getTypes();
  
  }
  getProducts(){
    this.shopService.getProducts().subscribe({
      next: response=> this.products = response.data,
      error: error => console.log(error)

    })
  
  }
  getBrands(){
    this.shopService.getBrands().subscribe({
      next: response=> this.brands = response,
      error: error => console.log(error)

    })

  }
  getTypes(){
    this.shopService.getTypes().subscribe({
      next: response=> this.types = response,
      error: error => console.log(error)

    })

  }
}
