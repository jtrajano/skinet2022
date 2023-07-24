import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Product } from './shared/models/product';
import { Pagination } from './shared/models/pagination';



@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit{
  title = 'Skinet';
 

  
  constructor() { }

  ngOnInit(): void {

   

    
  }
}
