import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { concatMap, map, mergeMap, of, switchMap, tap } from 'rxjs';
import { IOrder } from 'src/Interfaces/Order';
import { environment } from 'src/environment';
@Injectable({
  providedIn: 'root'
})
export class DataService {
ordersWithMap$=of(1,2,4)
.pipe(
  map(id=>this.http.get<IOrder>(`${environment.favoriteUrl}/Order/GetWithId/?id=${id}`)
));

ordersWithConcatMap$=of(1,4)
.pipe(
  tap(id=>console.log('concatMap source Observable',id)),
  concatMap(id => this.http.get<IOrder[]>(`${environment.favoriteUrl}/Order/GetWithId/?id=${id}`)
));

ordersWithMergeMap$=of(1,4)
.pipe(
  tap(id=>console.log('mergeMap source Observable',id)),
  mergeMap(id => this.http.get<IOrder[]>(`${environment.favoriteUrl}/Order/GetWithId/?id=${id}`)
));

ordersWithSwitchMap$=of(1,4)
.pipe(
  tap(id=>console.log('switchMap source Observable',id)),
  switchMap(id => this.http.get<IOrder[]>(`${environment.favoriteUrl}/Order/GetWithId/?id=${id}`)
));



  constructor(private http: HttpClient) {

    this.ordersWithConcatMap$.subscribe(
      item=>console.log('Concatmap result',item)
    );

    this.ordersWithMergeMap$.subscribe(
      item=>console.log('Mergemap result',item)
    );

    this.ordersWithSwitchMap$.subscribe(
      item=>console.log('Switchmap result',item)
    );
    
    // this.ordersWithMap$.subscribe(
    //   item=>console.log('map result',item)
    // );
  }

  getData() {
    return this.http.get<IOrder[]>(`${environment.favoriteUrl}/Order/Get`);
  }
}
