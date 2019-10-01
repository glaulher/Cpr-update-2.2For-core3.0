
     $('#dataTable').DataTable({
        /*    "columnDefs": [
               {
                   // The `data` parameter refers to the data for the cell (defined by the
                   // `data` option, which defaults to the column being worked with, in
                   // this case `data: 0`.
                   "render": function ( data, type, row ) {
                       return data +' ('+ row[2]+')';
                   },
                   "targets": 0
               },
               { "visible": false,  "targets": [ 2 ] }
           ],   */
               "bJQueryUI": true,
                   "oLanguage": {
                       "sProcessing":   "Processando...",
                       "sLengthMenu":   "Mostrar _MENU_ registros",
                       "sZeroRecords":  "Não foram encontrados resultados",
                       "sInfo":         "Mostrando de _START_ até _END_ de _TOTAL_ registros",
                       "sInfoEmpty":    "Mostrando de 0 até 0 de 0 registros",
                       "sInfoFiltered": "",
                       "sInfoPostFix":  "",
                       "sSearch":       "Buscar:",
                       "sUrl":          "",
                       "oPaginate": {
                           "sFirst":    "Primeiro",
                           "sPrevious": "Anterior",
                           "sNext":     "Seguinte",
                           "sLast":     "Último"
                       }
                   },
           "footerCallback": function ( row, data, start, end, display ) {
               var api = this.api(), data;
    
               // Remove the formatting to get integer data for summation
               var intVal = function ( i ) {
                   return typeof i === 'string' ?
                       i.replace("R$","").replace(/[\$.]/g, '').replace(/[\$,]/g, '')*1 :
                       typeof i === 'number' ?
                           i : 0;
               };
    
               // Total over all pages
               total = api
                   .column( 4 )
                   .data()
                   .reduce( function (a, b) {
                       return intVal(a) + intVal(b);
                   }, 0 );
    
               // Total over this page
               pageTotal = api
                   .column( 4, { page: 'current'} )
                   .data()
                   .reduce( function (a, b) {
                       return intVal(a) + intVal(b);
                   }, 0 );
                   
                // Create our number formatter.
                var formatter = new Intl.NumberFormat('pt-BR', {
                    style: 'currency',
                    currency: 'BRL',
                });
  
                total = total/100;
               // Update footer
               $( api.column( 4 ).footer() ).html(
               //    '$'+pageTotal.toFixed(2).replace(".",",") +' ( $'+ total.toFixed(2).replace(".",",") +' total)'
               formatter.format(total)
               );
           }
       } );