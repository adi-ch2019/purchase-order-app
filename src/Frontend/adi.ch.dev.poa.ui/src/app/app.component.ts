import { Component, OnInit } from '@angular/core';
import { IOrder } from 'src/Interfaces/Order';
import { DataService } from 'src/services/DataService';
import { Subscription } from "rxjs";
@Component({
  selector: 'mov-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  pageTitle = 'adi.ch.dev.poa.ui';
  constructor(private dataService: DataService) {}
  sub!: Subscription;
  orders: IOrder[] = [];
  errorMessage = '';
  
  ngOnInit(): void {
    this.dataService.getData().subscribe({
      next: orders => {
        this.orders = orders;
        console.log('Orders:',this.orders);
      },
      error: (err: string) => this.errorMessage = err
    });
  }
}
