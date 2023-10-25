import { Component, OnInit } from '@angular/core';
import {of,from} from 'rxjs';

@Component({
  selector: 'mov-rxjs-demo',
  templateUrl: './rxjs-demo.component.html',
  styleUrls: ['./rxjs-demo.component.scss']
})
export class RxjsDemoComponent implements OnInit {

  ngOnInit(): void {
    of(2,4,6,8).subscribe(item => console.log(item));

    from([20,15,10,5]).subscribe({
      next: (item)=> console.log(`resulting item.. ${item}`),
      error: (err) => console.error(`error occurred ${err}`),
      complete: ()=>console.info('complete')
    });

    of('Apple1','Apple2','Apple3').subscribe({
      next:(apple)=>console.log(`Apple emitted ${apple}`),
      error: (err) => console.error(`Error occurred: ${err}`),
      complete: ()=>console.info('No more apples, go home')
    })
  }

}
