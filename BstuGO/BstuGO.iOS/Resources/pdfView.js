var url = 'https://feis.bstu.by/wp-content/uploads/2023/08/%D0%A4%D0%AD%D0%98%D0%A1-3.pdf';
  var canvas = document.getElementById('pdf-viewer');

  pdfjsLib.getDocument(url).promise.then(function(pdf) {
    pdf.getPage(1).then(function(page) {
      var viewport = page.getViewport({ scale: 1.0 });
      var context = canvas.getContext('2d');
      canvas.height = viewport.height;
      canvas.width = viewport.width;
      page.render({ canvasContext: context, viewport: viewport });
    });
  });