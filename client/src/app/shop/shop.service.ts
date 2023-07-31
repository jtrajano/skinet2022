import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Pagination } from '../shared/models/pagination';
import { Product } from '../shared/models/product';
import { Brand } from '../module/brand';
import { Type } from '../module/type';

@Injectable({
  providedIn: 'root'
})
export class ShopService {

  baseUrl = 'https://localhost:5000/api/';

  constructor(private http: HttpClient) { }

  getProducts(){
    return this.http.get<Pagination<Product[]>>( this.baseUrl + 'products?pageSize=50');
  }

  getBrands(){
    return this.http.get<Brand[]>( this.baseUrl + 'products/brands');
  
  }
  getTypes(){
    return this.http.get<Type[]>( this.baseUrl + 'products/types');
  
  }
}

