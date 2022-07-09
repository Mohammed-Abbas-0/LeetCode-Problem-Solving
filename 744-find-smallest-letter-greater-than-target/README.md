<h2><a href="https://leetcode.com/problems/find-smallest-letter-greater-than-target/">744. Find Smallest Letter Greater Than Target</a></h2><h3>Easy</h3><hr><div><p>Given a characters array <code data-copier-init="true">letters</code> that is sorted in <strong>non-decreasing</strong> order and a character <code data-copier-init="true">target</code>, return <em>the smallest character in the array that is larger than </em><code data-copier-init="true">target</code>.</p>

<p><strong>Note</strong> that the letters wrap around.</p>

<ul>
	<li>For example, if <code data-copier-init="true">target == 'z'</code> and <code data-copier-init="true">letters == ['a', 'b']</code>, the answer is <code data-copier-init="true">'a'</code>.</li>
</ul>

<p>&nbsp;</p>
<p><strong>Example 1:</strong></p>

<pre data-copier-init="true"><strong>Input:</strong> letters = ["c","f","j"], target = "a"
<strong>Output:</strong> "c"
</pre>

<p><strong>Example 2:</strong></p>

<pre data-copier-init="true"><strong>Input:</strong> letters = ["c","f","j"], target = "c"
<strong>Output:</strong> "f"
</pre>

<p><strong>Example 3:</strong></p>

<pre data-copier-init="true"><strong>Input:</strong> letters = ["c","f","j"], target = "d"
<strong>Output:</strong> "f"
</pre>

<p>&nbsp;</p>
<p><strong>Constraints:</strong></p>

<ul>
	<li><code data-copier-init="true">2 &lt;= letters.length &lt;= 10<sup>4</sup></code></li>
	<li><code data-copier-init="true">letters[i]</code> is a lowercase English letter.</li>
	<li><code data-copier-init="true">letters</code> is sorted in <strong>non-decreasing</strong> order.</li>
	<li><code data-copier-init="true">letters</code> contains at least two different characters.</li>
	<li><code data-copier-init="true">target</code> is a lowercase English letter.</li>
</ul>
</div>