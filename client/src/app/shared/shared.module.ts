import { PaginationModule } from 'ngx-bootstrap/pagination';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PaginationHeaderComponent } from './pagination-header/pagination-header.component';
import { PagerComponent } from './pager/pager.component';



@NgModule({
  declarations: [
    PaginationHeaderComponent,
    PagerComponent
  ],
  imports: [
    CommonModule,
    PaginationModule.forRoot() // singleton
  ],
  exports:[
    PaginationModule,
    PaginationHeaderComponent,
    PagerComponent
  ]
})
export class SharedModule { }
