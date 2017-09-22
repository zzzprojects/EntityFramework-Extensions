---
layout: dev
title: Pricing
permalink: pricing
---

{% include template-h1.html %}

<div class="row">
	<div class="col-lg-6">
	
<!-- validation !-->
<div id="error_validation" class="modal fade" tabindex="-1" role="dialog" aria-labelledby="modal_agreement" aria-hidden="true">
	<div class="modal-dialog" role="document">
		<div class="modal-content">
			<div class="modal-header">
				<h4 class="modal-title" id="modal_agreement">License Agreement</h4>
			</div>
			<div class="modal-body bg-danger">
				You must read and agree to the License Agreement.
			</div>
			<div class="modal-footer">
				<button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
			</div>
		</div>
	</div>
</div>
			
<form action="https://www.paypal.com/cgi-bin/webscr" method="post" target="_top" onsubmit="return purchase_validate()" style="width:450px;">
	<input type="hidden" name="cmd" value="_s-xclick">
	<input type="hidden" name="currency_code" value="USD">
	<fieldset class="form-group">
		<input type="hidden" name="on0" value="Seats">
		<label><b>Provider:</b></label> 
		<select id="provider_type" name="hosted_button_id" class="form-control" onchange="selectProduct()">
			<option value="GS977QXB98R2C">SQL Server/ Azure Provider</option>
			<option value="27ML36DSMHEQA">Oracle Provider</option>
			<option value="32JM43GUXW4ZW">MySQL Provider</option>
			<option value="TSCZ2KCM9QBVY">PostgreSQL</option>
			<option value="5WVPWVNDGRHH6">SQL Compact Provider</option>
			<option value="55WDUT7ENJBKU">SQLite Provider</option>
			<option value="TSCGQDC4YR2MQ">ALL Providers</option>
		</select> 
		<br />
		<label><b>Seat:</b></label> 
		<select id="product_option" name="os0" class="form-control">
			<option id="seat1" value="1 seat">Entity Framework Extensions $599 (1 developer seat)</option>
			<option id="seat2_4" value="2-4 seats" selected>Entity Framework Extensions $799 (2-4 developer seats)</option>
			<option id="seat5_9" value="5-9 seats">Entity Framework Extensions $999 (5-9 developer seats)</option>
			<option id="seat10_14" value="10-14 seats">Entity Framework Extensions $1199 (10-14 developer seats)</option>
			<option id="seat15_19" value="15-19 seats">Entity Framework Extensions $1399 (15-19 developer seats)</option>
		</select> 
	</fieldset>
	<div class="checkbox">
		<label>
			<input id="agree_agreement" type="checkbox">&nbsp;I have read and agree to the <a href="http://www.zzzprojects.com/license-agreement/" target="_blank">License Agreement</a>.
		</label>
	</div>
	<button type="submit" class="btn btn-success btn-lg"><span><i class="fa fa-shopping-cart"></i>&nbsp;<span>BUY NOW</span></span></button>
	<br /><br />
</form>	

	</div>
	<div class="col-lg-6">
	
<table class="table table-hover table-bordered" style="width: 340px;">
	<thead class="thead-inverse">
		<tr>
			<th>Features</th>
		</tr>
	</thead>
	<tbody>
		<tr>
			<th><i class="fa fa-check-square-o"></i>&nbsp;Bulk SaveChanges</th>
		</tr>
		<tr>
			<th><i class="fa fa-check-square-o"></i>&nbsp;Bulk Insert</th>
		</tr>
		<tr>
			<th><i class="fa fa-check-square-o"></i>&nbsp;Bulk Update</th>
		</tr>
		<tr>
			<th><i class="fa fa-check-square-o"></i>&nbsp;Bulk Delete</th>
		</tr>
		<tr>
			<th><i class="fa fa-check-square-o"></i>&nbsp;Bulk Merge</th>
		</tr>
		<tr>
			<th><i class="fa fa-check-square-o"></i>&nbsp;DeleteFromQuery</th>
		</tr>
		<tr>
			<th><i class="fa fa-check-square-o"></i>&nbsp;UpdateFromQuery</th>
		</tr>
		<tr>
			<th><i class="fa fa-check-square-o"></i>&nbsp;Commercial License</th>
		</tr>
		<tr>
			<th><i class="fa fa-check-square-o"></i>&nbsp;Royalty-Free</th>
		</tr>
		<tr>
			<th><i class="fa fa-check-square-o"></i>&nbsp;Support & Upgrades (1 year)</th>
		</tr>
	</tbody>
</table>

	</div>
</div>


--- 

## FAQ

### Why this library is not free and open source?
Don't get us wrong; We embrace the `free and open source` community.

We have developed and support several free library that you might already use:
- [Html Agility Pack](http://html-agility-pack.net/){:target="_blank"}
- [Entity Framework Plus](http://entityframework-plus.net/){:target="_blank"}
- [Entity Framework DynamicFilter](https://github.com/zzzprojects/EntityFramework.DynamicFilters){:target="_blank"}
- [RefactorThis.GraphDiff](https://github.com/zzzprojects/GraphDiff){:target="_blank"}
- [Extension Methods](https://github.com/zzzprojects/Z.ExtensionMethods){:target="_blank"}

We spent thousands of hours to make sure they stay supported and up to date.

We have great incoming projects to continue adding value to the `.NET Community`.

However, this kind of dedication can only be done by having also paid library.

### Do you support alternative payment method?
Yes, we support the following payment method:

- PayPal
- Cheque
- Wire Transfer

Contact us: <a href="mailto:info@zzzprojects.com">info@zzzprojects.com</a>

### I need more than 19 seats, what can I do?
Contact us: <a href="mailto:info@zzzprojects.com">info@zzzprojects.com</a>

### I want to purchase more than one `ZZZ Projects` product, do you offer discount?
Contact us: <a href="mailto:info@zzzprojects.com">info@zzzprojects.com</a>

<style>
.fa-check-square-o {
    color: #449d44;
}
</style>