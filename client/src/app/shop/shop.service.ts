import { HttpClient, HttpParams } from '@angular/common/http';
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

  getProducts(brandId?: number, typeId?: number, sort?: string){

    let params = new HttpParams();

    if (brandId)
      params = params.append('brandId', brandId);

    if (typeId)
      params = params.append('typeId', typeId);

    if(sort)
      params = params.append('sort', sort)

    // return this.http.get<Product[]>( this.baseUrl + 'products', { params: params }


    return this.http.get<Pagination<Product[]>>( this.baseUrl + 'products', {params});
  }

  getBrands(){
    return this.http.get<Brand[]>( this.baseUrl + 'products/brands');
  
  }
  getTypes(){
    return this.http.get<Type[]>( this.baseUrl + 'products/types');
  
  }
}

