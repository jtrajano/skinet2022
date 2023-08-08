import { PaginationModule } from 'ngx-bootstrap/pagination';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PaginationHeaderComponent } from './pagination-header/pagination-header.component';



@NgModule({
  declarations: [
    PaginationHeaderComponent
  ],
  imports: [
    CommonModule,
    PaginationModule.forRoot() // singleton
  ],
  exports:[
    PaginationModule,
    PaginationHeaderComponent
  ]
})
export class SharedModule { }
