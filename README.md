# Use Scanner In WebApplications
@ Access Scanner from Web Browsers By Reliable Browser-Based Document Scanning SDK @

This SDK designed for web document management applications. With just a few lines of JavaScript code, you can develop robust web applications to scan documents, edit images and save them to file systems or database on Windows.

in this application, I used TwainDotNet.dll for connecting to scanners. if you want to see or change and compile the source of this project you can check [NTwain-SourceCode](https://github.com/rhazizi/twaindotnet)

in angular you can use same as below code :

1- first make ScannedServcieResponse model
```javascript
export class ScannedServcieResponse {
  IsSuccess: boolean;
  Message: string;
  result: any[];
}
```
2- Call scanner service and deserializing json to ScannedServcieResponse model.
```javascript
imageScanClick(): void {
    this.isLoading = true;
    this.notif.info('در حال ارتباط با اسکنر...');
    $.ajax({
      url: "http://localhost:6565",
      data: { mode: 'SCAN' },
      type: 'POST',
      complete: function () {
      },
      success: (data) => {
        const servcieResult = <ScannedServcieResponse>JSON.parse(data);
        if (servcieResult.IsSuccess) {
          for (let index = 0; index < servcieResult.result.length; index++) {
            const element = servcieResult.result[index];
            });
          }
        }
        this.notif.clear();
        this.isLoading = false;
      },
      error: (xhr, textStatus, errorThrown) => {
        console.error('Scanner Service not found!');
        this.notif.error('سرویس اسکنر پیدا نشد!');
        this.isLoading = false;
      }
    });
  }
  ```
