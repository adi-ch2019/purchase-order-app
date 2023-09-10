import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IOrder } from 'src/Interfaces/Order';
import { environment } from 'src/environment';
@Injectable({
  providedIn: 'root'
})
export class DataService {
  constructor(private http: HttpClient) {}

  getData() {
    return this.http.get<IOrder[]>(`${environment.favoriteUrl}/Order`);
  }
}
